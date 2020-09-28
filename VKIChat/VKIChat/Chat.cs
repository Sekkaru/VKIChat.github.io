using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKIChat
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }
        static string VKIChat = @"T:\703б1\VKIChat.txt";
        string line;

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(VKIChat, true, System.Text.Encoding.Default);
            sw.WriteLine(textBox2.Text + ": " + textBox1.Text);
            textBox1.Clear();
            sw.Close();

            if (System.IO.File.ReadAllLines(VKIChat).Length < 15)
            {
               
                StreamReader sr = new StreamReader(VKIChat, System.Text.Encoding.Default);
                line = sr.ReadToEnd();
                label1.Text = line;
                sr.Close();
            }
            else
            {
                label1.Text = " ";
                StreamReader sr = new StreamReader(VKIChat, System.Text.Encoding.Default);
                line = sr.ReadToEnd();
                label1.Text = line;
                sr.Close();
            }
            label4.Text = Convert.ToString(System.IO.File.ReadAllLines(VKIChat).Length);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(VKIChat, System.Text.Encoding.Default);
            line = sr.ReadToEnd();
            label1.Text = line;
            sr.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(VKIChat, System.Text.Encoding.Default);
            line = sr.ReadToEnd();
            label1.Text = line;
            sr.Close();
        }
    }
}
