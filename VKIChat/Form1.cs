using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VKIChat
{
    public partial class Form1 : Form
    {
        string connString = @"server=remotemysql.com;user=6PKeY23Bcb;database=6PKeY23Bcb;port=3306;password=HWiidJ4pHF";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("select * from Messages", conn);
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text += reader["MessageId"] + " " + reader["MessageText"] + " " + reader["MessageUserName"] + " " + reader["MessageDatetime"] + "\n";
                }
            }
        }
    }
}
