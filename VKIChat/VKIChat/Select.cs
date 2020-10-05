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
    public partial class Select : Form
    {
        List<Button> confButtonList = new List<Button>(); //Хранит список кнопок для выбора конфы
        string strConn = @"server=remotemysql.com;user=6PKeY23Bcb;database=6PKeY23Bcb;port=3306;password=HWiidJ4pHF";
        public Select()
        {
            InitializeComponent();
            UsernameField.Text += UserInfo.username;
            refreshConfs();
        }

        private void Select_Load(object sender, EventArgs e)
        {

        }

        private void CreateConfBtn_Click(object sender, EventArgs e)
        {
            //TODO: генерить новые конфы через форму\диалоговое окно
            refreshConfs();
        }
        private void refreshConfs() //Перезагружает список бесед, вызывается при открытии формы и при добавлении новой конфы
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                foreach(Button btn in confButtonList)
                {
                    btn.Dispose();
                    Controls.Remove(btn); //Возможно не работает, хех
                }
                MySqlCommand command = new MySqlCommand("select * from Confs", conn);
                MySqlDataReader reader = command.ExecuteReader();
                ConfList.Text = "Список бесед:";
                int i = 0;
                while (reader.Read())
                {
                    ConfList.Text += "\n" + reader["Name"] + "\n";
                    Button btn = new Button();
                    string tmp = reader["Id"].ToString();
                    btn.Click += new EventHandler((sender, e) => ConfBtnClick(sender, tmp));
                    btn.Location = new Point(160,75+26*i++); //TODO подогнать позиционироване копок, либо вообще переделать
                    btn.Size = new Size(70, 25); //TODO: да и вообще переписать этот ужас на нормальный лад
                    this.Controls.Add(btn);
                    confButtonList.Add(btn);
                }
            }
        }
        void ConfBtnClick(object sender, string e) //Триггерится при выборе конфы, в "e" лежит номер беседы
        {
            MessageBox.Show("выбрана беседа "+e);
        }
    }
}
