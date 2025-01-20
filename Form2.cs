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
            if (tboxName.Text == null)
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
                    string query2 = string.Format("select * from sales_tb where concat(`name`, `price`, `count`, `total`) like '%{0}%'", searchInfo);

                    command = new MySqlCommand(query2, conn);
                    adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    dgViewHistory.DataSource = dt;

                }
                tboxName.Clear();
            }
        }

        private void dgViewHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxID.Text = dgViewHistory.Rows[e.RowIndex].Cells[0].Value.ToString();
            tboxName.Text = dgViewHistory.Rows[e.RowIndex].Cells[1].Value.ToString();
            tboxPrice.Text = dgViewHistory.Rows[e.RowIndex].Cells[2].Value.ToString();
            tboxCount.Text = dgViewHistory.Rows[e.RowIndex].Cells[3].Value.ToString();
            tboxTotal.Text = dgViewHistory.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (tboxName.Text == "" || tboxPrice.Text == "" || tboxCount.Text == "")
            {
                MessageBox.Show("수정할 항목을 제대로 입력해주세요.");
            }
            else if(int.Parse(tboxCount.Text) < 0)
            {
                MessageBox.Show("숫자는 0 이상입니다.");
            }
            else
            {
                string name = tboxName.Text;
                int price = int.Parse(tboxPrice.Text);
                int count = int.Parse(tboxCount.Text);
                int total = price * count;
                tboxTotal.Text = total.ToString();

                conn = new MySqlConnection(server_con);
                using (conn)
                {
                    conn.Open();
                    string quary = string.Format("update sales_tb set name = '{0}', price = {1}, count = {2}, total = {3} where no = {4}", name, price, count, total, tboxID.Text);
                    command = new MySqlCommand(quary, conn);
                    try
                    {
                        command.ExecuteNonQuery(); // insert, update, delete, create table 데이터가 변경됨
                        MessageBox.Show("수정 완료");
                        //command.ExecuteScalar();    // sum, count, max, min 등등
                        //using (MySqlDataReader reader = cmd.ExecuteReader())  // 주로 select 명령어 읽을 때
                        //{
                        //    while (reader.Read())
                        //    {
                        //        Console.WriteLine(reader["name"] + " - " + reader["price"]);
                        //    }
                        //}
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                LoadData();
            }
        }
    }
}
