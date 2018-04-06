using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private static string label_text_auth_login = "Логин";
        private static string label_text_auth_passwd = "Пароль";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_verification_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.Text = label_text_auth_login;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.label1.Text = label_text_auth_passwd;
        }
    }
}
