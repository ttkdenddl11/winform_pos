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
        public Form1()
        {
            InitializeComponent();
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
    }
}
