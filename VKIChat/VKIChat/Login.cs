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
    public partial class Login : Form
    {
        public static int id_user;
        public Login()
        {
            InitializeComponent();
        }

        string strConn = @"server=remotemysql.com;user=6PKeY23Bcb;database=6PKeY23Bcb;port=3306;password=HWiidJ4pHF";
        private void Button2_Click(object sender, EventArgs e)
        {
            Registration oldForm = new Registration();
            this.Hide();
            oldForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string sel = $"select count(*) from `Users` where UserName = '{txtLOGIN.Text}', UserPassword = '{txtPASS.Text}'";
            }
        }
    }
}
