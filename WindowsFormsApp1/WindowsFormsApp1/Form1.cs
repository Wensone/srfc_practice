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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_verification_Click(object sender, EventArgs e)
        {
            enter_login = this.login.Text;
            enter_passwd = this.password.Text;

            string connStr = "server=172.22.1.11\\ONE_C;user=student;database=Student;password=Qwerty123;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "SELECT [login], [passwd] FROM " + auth_table;
            SqlCommand command = new SqlCommand(sql, conn);
            // command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            bool isAuth = false;
            while (reader.Read())
            {
                if (reader[0].ToString().Equals(enter_login))
                {
                    if (reader[1].ToString().Equals(enter_passwd))
                    {
                        isAuth = true;
                        MessageBox.Show("Найдено и авторизованно");

                        // TODO передать в форму данные
                        // логин, пароль, тип пользователя(админ или юзер)
                        // алмин - rwx
                        // юзер - rx
                        if (isAuth)
                        {
                            break;
                        }
                    } else
                    {
                        // если не верный пасс
                        continue;
                    }
                } else
                {
                    // если не верный логин
                    
                    continue;
                }
            }

            if (!isAuth) MessageBox.Show("Test");

            reader.Close();
            conn.Close();
            /*
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // TODO: обработка текста ЛОГИН на окне авторизации
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // TODO: обработка текста ПАРОЛЬ на окне авторизации
        }

        private void registration_Click(object sender, EventArgs e)
        {
            Registration rega = new Registration();
            //this.Hide();
            rega.Show();
        }
    }
}
