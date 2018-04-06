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
    public partial class Registration : Form
    {
        private static string auth_table = "[Student].[dbo].[auth]";
        string connStr = "server=172.22.1.11\\ONE_C;user=student;database=Student;password=Qwerty123;";
        private string enter_login = "";
        private string enter_password = "";

        public Registration()
        {
            InitializeComponent();
            this.user_type.SelectedIndex = 0;
            
        }

        private void rega_Click(object sender, EventArgs e)
        {
            enter_login = this.reg_login.Text;
            enter_password = this.reg_password.Text;

            if (check_users(enter_login))
            {
                return;
            }

            int enter_type = Convert.ToInt32(this.user_type.SelectedItem.ToString());
               
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = "INSERT INTO " + 
                auth_table + 
                " ([login], [passwd], [type]) " + 
                "VALUES('" + enter_login + "', " +
                "'" + enter_password + "', " +
                enter_type + ");";

            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Пользователь " + enter_login + " зарегистрирован.");
            this.Close();
        }

        private bool check_users(string login)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = "SELECT [login] FROM [auth];";

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                if (reader[0].ToString().Equals(login)){
                    // TODO пофиксить отображение имени пользователя
                    MessageBox.Show("Пользователь с именем " + login + " уже зарегистрирован");
                    return true;
                }
            }

            conn.Close();
            reader.Close();

            return false;
        }
    }
}
