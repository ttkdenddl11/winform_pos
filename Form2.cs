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
    public partial class Form2 : Form
    {
        private string server_con = "Server=localhost;Port=3306;Database=pos_dataset;Uid=dongjin;pwd=park228577!;charset=utf8mb4;";
        MySqlConnection conn = null;
        MySqlCommand command = null;
        MySqlDataAdapter adapter = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void LoadData()
        {
            using (conn = new MySqlConnection(server_con))
            {
                conn.Open();

                string com = "select * from sales_tb";
                command = new MySqlCommand(com, conn);

                try
                {
                    adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dt;
                    dgViewHistory.DataSource = bSource;
                    adapter.Update(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tboxName.Text == null)
            {
                MessageBox.Show("검색 정보를 입력해주세요.");
            } 
            else
            {
                string searchInfo = tboxSearch.Text;

                using (conn = new MySqlConnection(server_con))
                {
                    conn.Open();
                    string query = "select * from sales_tb where concat(`name`, `price`, `count`, `total`) like '%" + searchInfo + "%'";
                    command = new MySqlCommand(query, conn);
                    adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    dgViewHistory.DataSource = dt;

                }
                tboxName.Clear();
            }
        }
    }
}
