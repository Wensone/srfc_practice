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
            String own_name         = this.textBox1.Text;
            String own_inn          = this.textBox2.Text;
            int own_zip             = Convert.ToInt32(this.textBox3.Text);
            String ownertyp_name    = this.textBox4.Text;
            String ownertyp         = this.textBox5.Text;
            String pred_typ         = this.textBox6.Text;
            String fio_otv          = this.textBox7.Text;
            String buhphone         = this.textBox8.Text;

            if(own_name.Equals("") || own_inn.Equals("") || own_zip < 0 || own_zip > 999999999 || ownertyp_name.Equals("") || ownertyp.Equals("") || pred_typ.Equals("") || fio_otv.Equals("") || buhphone.Equals(""))
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
