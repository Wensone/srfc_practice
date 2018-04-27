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
using System.IO;

namespace WindowsFormsApp1
{
    public class ProcessedData
    {
        FileStream stream;
        DataRow[][] data;
        string path = @"C:\Users\manakov_pd\Source\Repos\srfc_practice\WindowsFormsApp1\WindowsFormsApp1\MAP3\geoJSON.js";
        public ProcessedData(DataRow[][] rows)
        {
            stream = File.Open(path, FileMode.Create);
            data = rows;
            parse_db();
        }

        public void parse_db()
        {
            add_to_file("var points = { \"type\": \"FeatureCollection\",\"features\": [\n");
            for (int i = 0; i < data.Count(); i++)
            {
                int id = Convert.ToInt32(data[i][0].ItemArray.GetValue(0));
                int lathr = Convert.ToInt32(data[i][0].ItemArray.GetValue(6));
                int longtr = Convert.ToInt32(data[i][0].ItemArray.GetValue(9));
                string address = Convert.ToString(data[i][0].ItemArray.GetValue(20));
                string ready_string = "{\"geometry\": {\"type\": \"Point\",\"coordinates\": [" +
                    longtr + ", " + lathr +
                    "]},\"type\": \"Feature\",\"properties\": {\"popupContent\": " +
                    "\"" + address + "\"" +
                    "},\"id\": " +
                    id +
                    "}" + (i == data.Count() - 1 ? "\n]};" : ",\n");

                add_to_file(win_to_utf(ready_string));
            }
            stream.Close();
        }

        public string win_to_utf(string text)
        {
            Encoding utf8 = Encoding.GetEncoding("UTF-8");
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");

            byte[] utf8Bytes = win1251.GetBytes(text);
            byte[] win1251Bytes = Encoding.Convert(win1251, utf8, Encoding.Default.GetBytes(text));
            return win1251.GetString(win1251Bytes);
        }

        public void add_to_file(string str)
        {
            stream.Write(Encoding.Default.GetBytes(str), 0, str.Length);
        } 
    }
    public partial class Form2 : Form
    {
        SqlConnection connection;
        DataSet filter_set;
        public Form2()
        {
            InitializeComponent();
            filter_set = new DataSet();
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
            SqlCommand select_sites = new SqlCommand("SELECT * FROM dbo.sites", connection);
            SqlDataReader table = select_sites.ExecuteReader();
            DataTable sites_table = new DataTable();
            sites_table.Load(table);
            sites_table.TableName = "sites";
            studentDataSet.Tables.Add(sites_table);
            studentDataSet.Relations.Add("FK_site_id", studentDataSet.Tables["station"].Columns["site_id"], 
                studentDataSet.Tables["sites"].Columns["site_id"], false);
            filter_set = studentDataSet.Clone();

            ownersTableAdapter.Fill(studentDataSet.owners);
            stationTableAdapter.Fill(studentDataSet.station);
            freqTableAdapter.Fill(studentDataSet.freq);
            soglasTableAdapter.Fill(studentDataSet.soglas);
            frset_sitesTableAdapter.Fill(studentDataSet.frset_sites);
            frset_freqsTableAdapter.Fill(studentDataSet.frset_freqs);
            frset_ant_infTableAdapter.Fill(studentDataSet.frset_ant_inf);
            freq_ant_infTableAdapter.Fill(studentDataSet.freq_ant_inf);

            agent_information.RowHeadersVisible = false;
            station_information.RowHeadersVisible = false;
            freq_information.RowHeadersVisible = false;
            ant_information.RowHeadersVisible = false;
            soglas_grid.RowHeadersVisible = false;
            frset_sites_grid.RowHeadersVisible = false;
            frset_freqs_grid.RowHeadersVisible = false;
            ant_inf_grid.RowHeadersVisible = false;

            agent_information.DataSource = filter_set.Tables["owners"];
            station_information.DataSource = filter_set.Tables["station"];
            freq_information.DataSource = filter_set.Tables["freq"];
            ant_information.DataSource = filter_set.Tables["freq_ant_inf"];
            soglas_grid.DataSource = filter_set.Tables["soglas"];
            frset_sites_grid.DataSource = filter_set.Tables["frset_sites"];
            frset_freqs_grid.DataSource = filter_set.Tables["frset_freqs"];
            ant_inf_grid.DataSource = filter_set.Tables["frset_ant_inf"];
        }

        public void load_agent()
        {
            SqlCommand select_owner = new SqlCommand("SELECT * FROM dbo.owners WHERE own_name = '" + agents.SelectedNode.Text + "';", connection);
            SqlDataReader information = select_owner.ExecuteReader();
            filter_set.Tables["owners"].Clear();
            filter_set.Tables["owners"].Load(information);
        }

        private void agents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            filter_set.Tables["station"].Rows.Clear();
            filter_set.Tables["freq"].Rows.Clear();
            filter_set.Tables["freq_ant_inf"].Rows.Clear();
            filter_set.Tables["soglas"].Rows.Clear();
            filter_set.Tables["frset_sites"].Rows.Clear();
            filter_set.Tables["frset_freqs"].Rows.Clear();
            filter_set.Tables["frset_ant_inf"].Rows.Clear();
            load_agent();
            this.rich_res_tab_SelectedIndexChanged(sender, e);
        }

        private void station_information_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow parent_row = station_information.CurrentRow;
            if (parent_row == null)
            {
                return;
            }
            int stat_id = Convert.ToInt32(parent_row.Cells[0].Value);
            DataRow[] station = studentDataSet.Tables["station"].Select("stat_id = " + stat_id);
            DataRow[] child_rows = station[0].GetChildRows("FK_freq_station");
            filter_set.Tables["freq"].Clear();
            for (int i = 0; i < child_rows.Count(); i++) filter_set.Tables["freq"].Rows.Add(child_rows[i].ItemArray);
            if (freq_information.Rows.Count != 0) freq_information.Rows[0].Selected = false;
        }

        private void freq_information_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow parent_row = freq_information.CurrentRow;
            if (parent_row == null)
            {
                return;
            }
            int freq_ant_inf_id = Convert.ToInt32(parent_row.Cells[2].Value);
            DataRow[] station = studentDataSet.Tables["freq"].Select("freq_ant_inf_id = " + freq_ant_inf_id);
            DataRow[] child_rows = station[0].GetChildRows("FK_freq_freq_ant_inf");
            filter_set.Tables["freq_ant_inf"].Clear();
            for (int i = 0; i < child_rows.Count(); i++) filter_set.Tables["freq_ant_inf"].Rows.Add(child_rows[i].ItemArray);
            if (ant_information.Rows.Count != 0) ant_information.Rows[0].Selected = false;
        }

        private void soglas_grid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow parent_row = soglas_grid.CurrentRow;
            if (parent_row == null)
            {
                return;
            }
            int soglas_id = Convert.ToInt32(parent_row.Cells[0].Value);
            DataRow[] station = studentDataSet.Tables["soglas"].Select("sogl_id = " + soglas_id);
            DataRow[] child_rows = station[0].GetChildRows("FK_frset_sites_soglas");
            filter_set.Tables["frset_sites"].Clear();
            for (int i = 0; i < child_rows.Count(); i++) filter_set.Tables["frset_sites"].Rows.Add(child_rows[i].ItemArray);
            if (frset_sites_grid.Rows.Count != 0) frset_sites_grid.Rows[0].Selected = false;
        }

        private DataRow[][] add_sites()
        {

            DataRow[][] sites;
            DataRow[] owner = studentDataSet.Tables["owners"].Select("own_name = '" + agents.SelectedNode.Text + "'");
            DataRow[] stations = owner[0].GetChildRows("FK_station_owners");
            int count = 0;
            for (; count < stations.Count(); count++)
            {
                string a = Convert.ToString(stations[count].ItemArray.GetValue(3));
                if (a.Equals("")) break;
            }
            sites = new DataRow [count][];
            for (int i = 0; i < count; i++)
            {
                string a = Convert.ToString(stations[i].ItemArray.GetValue(3));
                if (!a.Equals("")) sites[i] = stations[i].GetChildRows("FK_site_id");
            }
            return sites;
        }

        private void rich_res_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] owner = studentDataSet.Tables["owners"].Select("own_name = '" + agents.SelectedNode.Text + "'");
            DataRow[] child_rows = null;
            if (this.rich_res_tab.SelectedIndex == 0)
            {
                child_rows = owner[0].GetChildRows("FK_station_owners");
                if (child_rows.Count() == 0) filter_set.Tables["freq"].Clear();
                filter_set.Tables["station"].Clear();
                for (int i = 0; i < child_rows.Count(); i++) filter_set.Tables["station"].Rows.Add(child_rows[i].ItemArray);
                if (station_information.Rows.Count != 0) station_information.Rows[0].Selected = false;
                station_information.Columns[station_information.Columns.Count - 1].Visible = false;
            } else if (this.rich_res_tab.SelectedIndex == 1)
            {
                child_rows = owner[0].GetChildRows("FK_soglas_owners");
                if (child_rows.Count() == 0) filter_set.Tables["soglas"].Clear();
                filter_set.Tables["soglas"].Clear();
                for (int i = 0; i < child_rows.Count(); i++) filter_set.Tables["soglas"].Rows.Add(child_rows[i].ItemArray);
                if (soglas_grid.Rows.Count != 0) soglas_grid.Rows[0].Selected = false;
                soglas_grid.Columns[1].Visible = false;
            } else
            {
                MessageBox.Show("Ошибка считывания таблицы овнерс", "Ошибка базы данных");
            }
            
        }

        private void frset_sites_grid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow parent_row = frset_sites_grid.CurrentRow;
            if (parent_row == null)
            {
                return;
            }

            int sites_id = Convert.ToInt32(parent_row.Cells[0].Value);
            DataRow[] station = studentDataSet.Tables["frset_sites"].Select("frset_sites_id = " + sites_id);
            DataRow[] child_rows = station[0].GetChildRows("FK_frset_freqs_frset_sites");
            DataRow[] child_rows_ant = station[0].GetChildRows("FK_frset_ant_inf_frset_sites");

            filter_set.Tables["frset_freqs"].Clear();
            filter_set.Tables["frset_ant_inf"].Clear();
            for (int i = 0; i < child_rows.Count(); i++) filter_set.Tables["frset_freqs"].Rows.Add(child_rows[i].ItemArray);
            for (int i = 0; i < child_rows_ant.Count(); i++) filter_set.Tables["frset_ant_inf"].Rows.Add(child_rows_ant[i].ItemArray);
            if (frset_freqs_grid.Rows.Count != 0) frset_freqs_grid.Rows[0].Selected = false;
            if (ant_inf_grid.Rows.Count != 0) ant_inf_grid.Rows[0].Selected = false;

        }

        private void agent_add_button_Click(object sender, EventArgs e)
        {
            DataProcessing dp = new DataProcessing(agents);
            dp.ShowDialog();
            ownersTableAdapter.Fill(studentDataSet.owners);
        }

        private void agent_edit_button_Click(object sender, EventArgs e)
        {
            AgentEdit edit_window = new AgentEdit(agents, agent_information.CurrentRow);
            edit_window.ShowDialog();
            load_agent();
            ownersTableAdapter.Fill(studentDataSet.owners);
        }

        private void agent_delete_button_Click(object sender, EventArgs e)
        {
            SqlCommand delete_command = new SqlCommand("DELETE FROM dbo.owners WHERE own_name = '" + agents.SelectedNode.Text + "';", connection);
            delete_command.ExecuteNonQuery();
            agents.SelectedNode.Remove();
        }

        private void selectStationsOnMap_Click(object sender, EventArgs e)
        {
            DataRow[][] temp_sites = add_sites();

            if (temp_sites.Count() == 0)
            {
                MessageBox.Show("Для этих станций не указана геолокация", "Еррор");
                return;
            }
            ProcessedData data = new ProcessedData(temp_sites);
            viewMapStaton vms = new viewMapStaton();
            vms.Show();
        }
    }
}
