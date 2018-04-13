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
            agent_information.RowHeadersVisible = false;
            station_information.RowHeadersVisible = false;
            station_information.Columns[station_information.Columns.Count - 1].Visible = false;
        }

        private void agents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            DataSet data_set = new DataSet();
            string command = "select * from dbo.owners";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            adapter.Fill(data_set, "dbo.owners");
            command = "select * from dbo.station";
            SqlDataAdapter adapter_1 = new SqlDataAdapter(command, connection);
            adapter_1.Fill(data_set, "dbo.station");
            DataRelation owner_station_relation = new DataRelation("OWNER_STATION", data_set.Tables["dbo.owners"].Columns["owner_id"], data_set.Tables["dbo.station"].Columns["OWNER_ID"]);
            data_set.Relations.Add(owner_station_relation);
            DataRow[] owner = data_set.Tables["dbo.owners"].Select("own_name = '" + agents.SelectedNode.Text + "'");
            studentDataSet.Tables["owners"].Clear();
            studentDataSet.Tables["owners"].Rows.Add(owner[0].ItemArray);
            DataRow[] child_rows = null;
            child_rows = owner[0].GetChildRows(owner_station_relation);
            studentDataSet.Tables["station"].Clear();
            for (int i = 0; i < child_rows.Count(); i++) studentDataSet.Tables["station"].Rows.Add(child_rows[i].ItemArray);
        }
        
    }
}
