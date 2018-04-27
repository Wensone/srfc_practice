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
        string connection_string = "Data Source = 172.22.1.11\\ONE_C; Initial Catalog = Student; Persist Security Info = True; User ID = student; Password = Qwerty123";
        TreeView owners;
        public DataProcessing(TreeView owners)
        {
            InitializeComponent();
            this.owners = owners;
        }

        private void AddUser(String own_name,
                            String own_inn,
                            int own_zip,
                            String ownertyp_name,
                            String ownertyp,
                            String pred_typ,
                            String fio_otv,
                            String buhphone)
        {
            // название процедуры
            string sqlExpression = "insert_owner";

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter[] a = new SqlParameter[8];
                a[0] = new SqlParameter{
                    ParameterName = "@a",
                    Value = own_name
                };
                a[1] = new SqlParameter
                {
                    ParameterName = "@b",
                    Value = own_inn
                };
                a[2] = new SqlParameter
                {
                    ParameterName = "@c",
                    Value = own_zip
                };
                a[3] = new SqlParameter
                {
                    ParameterName = "@d",
                    Value = ownertyp_name
                };
                a[4] = new SqlParameter
                {
                    ParameterName = "@e",
                    Value = ownertyp
                };
                a[5] = new SqlParameter
                {
                    ParameterName = "@f",
                    Value = pred_typ
                };
                a[6] = new SqlParameter
                {
                    ParameterName = "@g",
                    Value = fio_otv
                };
                a[7] = new SqlParameter
                {
                    ParameterName = "@h",
                    Value = buhphone
                };
                
                for (int i = 0; i < 8; i++)
                {
                    command.Parameters.Add(a[i]);
                }
                
                var result = command.ExecuteNonQuery();
                if (result == 1)
                {
                    owners.Nodes.Add("agents", own_name);
                }
                this.Close();
            }
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
               own_name          = this.textBox1.Text;
               own_inn           = this.textBox2.Text;
               own_zip       = Convert.ToInt32(this.textBox3.Text);
               ownertyp_name = this.textBox4.Text;
               ownertyp      = this.textBox5.Text;
               pred_typ          = this.textBox6.Text;
               fio_otv               = this.textBox7.Text;
               buhphone          = this.textBox8.Text;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }
        
            if(own_name.Equals("") || own_inn.Equals("") || own_zip < 0 || own_zip > 999999 || ownertyp_name.Equals("") || ownertyp.Equals("") || pred_typ.Equals("") || fio_otv.Equals("") || buhphone.Equals(""))
            {
                MessageBox.Show("Некоторые данные введены некорректно", "Ошибка ввода");
                return;
            }

            AddUser(
                own_name,
                own_inn,
                own_zip,
                ownertyp_name,
                ownertyp,
                pred_typ,
                fio_otv,
                buhphone
            );

            return;
            /**
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
            this.Close();*/
        }
    }
}
