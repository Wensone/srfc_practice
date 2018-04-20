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

        private void agents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataRow[] owner = studentDataSet.Tables["owners"].Select("own_name = '" + agents.SelectedNode.Text + "'");
            filter_set.Tables["owners"].Clear();
            filter_set.Tables["owners"].Rows.Add(owner[0].ItemArray);
            this.rich_res_tab_SelectedIndexChanged(sender, e);
            /*child_rows = owner[0].GetChildRows("FK_station_owners");
            if (child_rows.Count() == 0) filter_set.Tables["freq"].Clear();
            filter_set.Tables["station"].Clear();
            for (int i = 0; i < child_rows.Count(); i++) filter_set.Tables["station"].Rows.Add(child_rows[i].ItemArray);
            if (station_information.Rows.Count != 0) station_information.Rows[0].Selected = false;
            
            station_information.Columns[station_information.Columns.Count - 1].Visible = false;*/
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

    }
}
