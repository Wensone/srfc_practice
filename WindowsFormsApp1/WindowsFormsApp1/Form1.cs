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
        class Verification
        {
            public bool isFill = false;
            public string type;
            public string table;
            public string login;
            public string password;

            public Verification()
            {
                type = table = login = password = "empty";
            }

            public string getData()
            {
                return type + table + login + password;
            }
        }


        private static string label_text_auth_login = "Логин";
        private static string label_text_auth_passwd = "Пароль";
        private static string label_text_type_database = "База да";
        Verification ver = new Verification();
        public string[] RES = new string[3];
        public string[] RICH = new string[4];

        public Form1()
        {
            InitializeComponent();
            
            
            RES[0] = "Таблица 1.1";
            RES[1] = "Таблица 1.2";
            RES[2] = "Таблица 1.3";

            RICH[0] = "Таблица 2.1";
            RICH[1] = "Таблица 2.2";
            RICH[2] = "Таблица 2.3";
            RICH[3] = "Таблица 2.4";


            this.type.SelectedIndex = 0;
            this.table.SelectedIndex = 0;
        }

        public void setRES(ComboBox cb)
        {
            cb.Items.Clear();
            foreach (string it in RES)
            {
                cb.Items.Add(it);
            }
        }

        public void setRICH(ComboBox cb)
        {
            cb.Items.Clear();
            foreach (string it in RICH)
            {
                cb.Items.Add(it);
            }
        }

        private void button_verification_Click(object sender, EventArgs e)
        {
            ver.login = this.login.Text;
            ver.password = this.password.Text;

            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
            form2.Test(ver.getData());
            
            //MessageBox.Show(ver.type + " " + ver.table + " " + ver.login + " " + ver.password);
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type_db = this.type.SelectedItem.ToString();
            if (type_db.Equals("РЭС"))
            {
                ver.type = type_db;
                setRES(this.table);
            } else if (type_db.Equals("РИЧ"))
            {
                ver.type = type_db;
                setRICH(this.table);
            }
            this.table.SelectedIndex = 0;

        }

        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {
            ver.table =  this.table.SelectedItem.ToString();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.Text = label_text_auth_login;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.label1.Text = label_text_auth_passwd;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
