using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _45_DB_1_POS_Build
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
          
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Count", typeof(string));
            table.Columns.Add("Total", typeof(string));

            dgViewSale.DataSource = table;
            numItem.Value = 1;
            tboxSum.Enabled = false;
            tboxSum.Text = 0.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=dongjin;password=park228577!");
            connection.Open();
            if(connection.State == ConnectionState.Open)
            {
                lblStatus.Text = "Connected";
                lblStatus.ForeColor = Color.Black;
            } else
            {
                lblStatus.Text = "DisConnected";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tboxName.Text != null && tboxPrice.Text != null)
            {
                double price = double.Parse(tboxPrice.Text);
                int count = (int)numItem.Value;
                double total = price * count;

                table.Rows.Add(tboxName.Text, tboxPrice.Text, numItem.Value.ToString(), total.ToString());
                dgViewSale.DataSource = table;

                tboxName.Clear();
                tboxPrice.Clear();
                numItem.Value = 1;

                double all = 0;

                //foreach (DataRow oRow in table.Rows)
                //{
                //    all += double.Parse(oRow["Total"].ToString());
                //}

                for (int i = 0; i < dgViewSale.Rows.Count - 1; i++)
                {
                    all += double.Parse((dgViewSale.Rows[i].Cells[3].Value).ToString());
                }

                tboxSum.Text = all.ToString();

            } 
            else
            {
                MessageBox.Show("항목을 정확히 입력해주세요.");
                tboxName.Clear();
                tboxPrice.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow oRow in dgViewSale.SelectedRows)
            {
                dgViewSale.Rows.Remove(oRow);
                dgViewSale.DataSource = table;
            }
            double all = 0;
            for (int i = 0; i < dgViewSale.Rows.Count; i++)
            {
                all += Convert.ToDouble(dgViewSale.Rows[i].Cells[3].Value);
            }
            tboxSum.Text = all.ToString();
        }
    }
}
