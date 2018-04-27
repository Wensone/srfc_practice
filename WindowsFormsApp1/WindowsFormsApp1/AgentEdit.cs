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

    public partial class AgentEdit : Form
    {
        string connection_string = "Data Source = 172.22.1.11\\ONE_C; Initial Catalog = Student; Persist Security Info = True; User ID = student; Password = Qwerty123";
        TreeView owners;
        DataGridViewRow owner;
        public AgentEdit(TreeView owners, DataGridViewRow agent)
        {
            InitializeComponent();
            owner = agent;
            this.owners = owners;
            textBox1.Text = Convert.ToString(agent.Cells[1].Value);
            textBox2.Text = Convert.ToString(agent.Cells[3].Value);
            textBox3.Text = Convert.ToString(agent.Cells[4].Value);
            textBox4.Text = Convert.ToString(agent.Cells[7].Value);
            textBox5.Text = Convert.ToString(agent.Cells[8].Value);
            textBox6.Text = Convert.ToString(agent.Cells[9].Value);
            textBox7.Text = Convert.ToString(agent.Cells[16].Value);
            textBox8.Text = Convert.ToString(agent.Cells[17].Value);
        }

        private void UpdateUser(String own_name,
                            String own_inn,
                            int own_zip,
                            String ownertyp_name,
                            String ownertyp,
                            String pred_typ,
                            String fio_otv,
                            String buhphone, 
                            int _owner_id)
        {
            // название процедуры
            string sqlExpression = "update_owner";

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter[] a = new SqlParameter[9];
                a[0] = new SqlParameter
                {
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
                a[8] = new SqlParameter
                {
                    ParameterName = "@i",
                    Value = _owner_id
                };

                for (int i = 0; i < 9; i++)
                {
                    command.Parameters.Add(a[i]);
                }

                var result = command.ExecuteNonQuery();
                if (result == 1)
                {
                    owners.SelectedNode.Text = own_name;
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String own_name = "";
            String own_inn = "";
            int own_zip = -1;
            String ownertyp_name = "";
            String ownertyp = "";
            String pred_typ = "";
            String fio_otv = "";
            String buhphone = "";
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
            catch (ExecutionEngineException ex)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
            if (own_name.Equals("") || own_inn.Equals("") || own_zip < 0 || own_zip > 999999999 || ownertyp_name.Equals("") || ownertyp.Equals("") || pred_typ.Equals("") || fio_otv.Equals("") || buhphone.Equals(""))
            {
                MessageBox.Show("Некоторые данные введены некорректно", "Ошибка ввода");
                return;
            }

            int _owner_id = Convert.ToInt32(owner.Cells[0].Value);

            UpdateUser(
                own_name,
                own_inn,
                own_zip,
                ownertyp_name,
                ownertyp,
                pred_typ,
                fio_otv,
                buhphone,
                _owner_id
            );

            /**
            
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();
            SqlCommand edit_agent_command = new SqlCommand(
                    "UPDATE dbo.owners SET " + 
                    "own_name = " + "'" + own_name + "'," +
                    "own_inn = " + "'" + own_inn + "'," +
                    "own_zip = " + "" + own_zip + "," +
                    "ownertyp_name = " + "'" + ownertyp_name + "'," +
                    "ownertyp = " + "'" + ownertyp + "'," +
                    "pred_typ = " + "'" + pred_typ + "'," +
                    "fio_otv = " + "'" + fio_otv + "'," +
                    "buhphone = " + "'" + buhphone + "' " +
                    "WHERE owner_id = " + Convert.ToInt32(owner.Cells[0].Value) + ";",
                connection);
            if (edit_agent_command.ExecuteNonQuery() == 1)
            {
                owners.SelectedNode.Text = own_name;
            }
            this.Close();*/
        }
    }
}
