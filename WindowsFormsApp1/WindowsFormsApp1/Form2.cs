using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection connection;
        public Form2()
        {
            InitializeComponent();
            string connection_string = "Data Source = 172.22.1.11\\ONE_C; Initial Catalog = Student; Persist Security Info = True; User ID = student; Password = Qwerty123";
            connection = new SqlConnection(connection_string);
            connection.Open();
            SqlCommand owners = new SqlCommand("select * from dbo.owners", connection);
            SqlDataReader data = owners.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    object owner_name = data.GetValue(1);
                    agents.Nodes.Add("agents", Convert.ToString(owner_name));
                }
            }
            data.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void agents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string command = "select * from dbo.owners where own_name = '" + agents.SelectedNode.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataSet data_set = new DataSet();
            adapter.Fill(data_set);
            object own_id = data_set.Tables[0].Rows[0][0];
            agent_information.DataSource = data_set;
            agent_information.DataMember = data_set.Tables[0].TableName;
            command = "select * from dbo.station where OWNER_ID = " + own_id;
            adapter = new SqlDataAdapter(command, connection);
            adapter.Fill(data_set);
            station_information.DataSource = data_set;
            station_information.DataMember = data_set.Tables[0].TableName;
        }
    }
}
