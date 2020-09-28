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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        string strConn = @"server=remotemysql.com;user=6PKeY23Bcb;database=6PKeY23Bcb;port=3306;password=HWiidJ4pHF";

        private void Button2_Click(object sender, EventArgs e)
        {
            Login oldForm = new Login();
            this.Hide();
            oldForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string sel = "select * from `Users` where UserName = '" + txtLOGIN.Text + "'";
                string sql = "insert into `Users` (UserName, UserPassword) values ('" + txtLOGIN.Text + "','" + txtPASS.Text + "')";
                MySqlCommand comm = new MySqlCommand(sel, conn);
                MySqlDataReader sqlReader = null;
                sqlReader = comm.ExecuteReader();
                if (sqlReader.HasRows == true)
                {
                    MessageBox.Show("Такой пользователь существует");
                    sqlReader.Close();
                }
                else
                {
                    sqlReader.Close();
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();

                    txtLOGIN.Text = "";
                    txtPASS.Text = "";
                    MessageBox.Show("Вы успешно зарегались!");
                }
            }
        }
    }
}
