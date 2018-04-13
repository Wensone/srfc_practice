using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static string auth_table = "[Student].[dbo].[auth]";
        private string enter_login = "";
        private string enter_passwd = "";
        int ver = 2;
        
        public Form1()
        {
            InitializeComponent();
            ver = 1;
        }

        private void button_verification_Click(object sender, EventArgs e)
        {
            enter_login = this.login.Text;
            enter_passwd = this.password.Text;

            string connStr = 
                "server=172.22.1.11\\ONE_C;user=student;" +
                "database=Student;" +
                "password=Qwerty123;";

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "SELECT [login], [passwd] FROM " + auth_table;
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            bool isAuth = false;
            while (reader.Read())
            {
                if (reader[0].ToString().Equals(enter_login))
                {
                    if (reader[1].ToString().Equals(enter_passwd))
                    {
                        isAuth = true;
                        if (isAuth)
                        {
                            break;
                        }
                    } else
                    {
                        continue;
                    }
                } else
                {
                    continue;
                }
            }

            reader.Close();
            conn.Close();

            if (!isAuth)
            {
                MessageBox.Show("Проверьте корректность данных.", "Ошибка авторизации");
                return;
            }

            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            Registration rega = new Registration();
            rega.Show();
        }
    }
}
