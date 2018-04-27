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
    public partial class DataProcessing : Form
    {
        TreeView owners;
        public DataProcessing(TreeView owners)
        {
            InitializeComponent();
            this.owners = owners;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String own_name;
            String own_inn;
            int own_zip;
            String ownertyp_name;
            String ownertyp;
            String pred_typ;
            String fio_otv;
            String buhphone;
            try
            {
               own_name = this.textBox1.Text;
               own_inn = this.textBox2.Text;
               own_zip = Convert.ToInt32(this.textBox3.Text);
               ownertyp_name = this.textBox4.Text;
               ownertyp = this.textBox5.Text;
               pred_typ = this.textBox6.Text;
               fio_otv = this.textBox7.Text;
               buhphone = this.textBox8.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }
            if(own_name.Equals("") || own_inn.Equals("") || own_zip < 0 || own_zip > 999999 || ownertyp_name.Equals("") || ownertyp.Equals("") || pred_typ.Equals("") || fio_otv.Equals("") || buhphone.Equals(""))
            {
                MessageBox.Show("Некоторые данные введены некорректно", "Ошибка ввода");
            }

            string connection_string = "Data Source = 172.22.1.11\\ONE_C; Initial Catalog = Student; Persist Security Info = True; User ID = student; Password = Qwerty123";
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();
            SqlCommand add_agent_command = new SqlCommand(
                    "insert into owners " +
                    "(own_name, own_inn, own_zip, ownertyp_name, ownertyp, pred_typ, fio_otv, buhphone) " +
                    "values (" +
                    "'" + own_name + "'," +
                    "'" + own_inn + "'," +
                    "" + own_zip + "," +
                    "'" + ownertyp_name + "'," +
                    "'" + ownertyp + "'," +
                    "'" + pred_typ + "'," +
                    "'" + fio_otv + "'," +
                    "'" + buhphone + "')",
                connection);

            if (add_agent_command.ExecuteNonQuery() == 1)
            {
                owners.Nodes.Add("agents", own_name);
            }
            this.Close();
        }
    }
}
