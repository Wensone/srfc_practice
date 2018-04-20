namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.agents = new System.Windows.Forms.TreeView();
            this.agent_information = new System.Windows.Forms.DataGridView();
            this.rich_res_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.freq_information = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.station_information = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.freqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new WindowsFormsApp1.StudentDataSet();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freqTableAdapter = new WindowsFormsApp1.StudentDataSetTableAdapters.freqTableAdapter();
            this.stationTableAdapter = new WindowsFormsApp1.StudentDataSetTableAdapters.stationTableAdapter();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownersTableAdapter = new WindowsFormsApp1.StudentDataSetTableAdapters.ownersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ant_information = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.freqantinfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freq_ant_infTableAdapter = new WindowsFormsApp1.StudentDataSetTableAdapters.freq_ant_infTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.agent_information)).BeginInit();
            this.rich_res_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freq_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.station_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ant_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqantinfBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agents
            // 
            this.agents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.agents.Location = new System.Drawing.Point(13, 13);
            this.agents.Name = "agents";
            this.agents.Size = new System.Drawing.Size(170, 577);
            this.agents.TabIndex = 0;
            this.agents.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.agents_AfterSelect);
            // 
            // agent_information
            // 
            this.agent_information.AllowUserToAddRows = false;
            this.agent_information.AllowUserToDeleteRows = false;
            this.agent_information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agent_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agent_information.Location = new System.Drawing.Point(189, 13);
            this.agent_information.Name = "agent_information";
            this.agent_information.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agent_information.Size = new System.Drawing.Size(1079, 62);
            this.agent_information.TabIndex = 1;
            // 
            // rich_res_tab
            // 
            this.rich_res_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rich_res_tab.Controls.Add(this.tabPage1);
            this.rich_res_tab.Controls.Add(this.tabPage2);
            this.rich_res_tab.Location = new System.Drawing.Point(189, 82);
            this.rich_res_tab.Name = "rich_res_tab";
            this.rich_res_tab.SelectedIndex = 0;
            this.rich_res_tab.Size = new System.Drawing.Size(1083, 551);
            this.rich_res_tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ant_information);
            this.tabPage1.Controls.Add(this.freq_information);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.station_information);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "РЭС";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // freq_information
            // 
            this.freq_information.AllowUserToAddRows = false;
            this.freq_information.AllowUserToDeleteRows = false;
            this.freq_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.freq_information.Location = new System.Drawing.Point(0, 187);
            this.freq_information.Name = "freq_information";
            this.freq_information.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.freq_information.Size = new System.Drawing.Size(1085, 112);
            this.freq_information.TabIndex = 3;
            this.freq_information.SelectionChanged += new System.EventHandler(this.freq_information_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Частоты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Станции:";
            // 
            // station_information
            // 
            this.station_information.AllowUserToAddRows = false;
            this.station_information.AllowUserToDeleteRows = false;
            this.station_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.station_information.Location = new System.Drawing.Point(0, 44);
            this.station_information.Name = "station_information";
            this.station_information.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.station_information.Size = new System.Drawing.Size(1085, 100);
            this.station_information.TabIndex = 0;
            this.station_information.SelectionChanged += new System.EventHandler(this.station_information_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "РИЧ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // freqBindingSource
            // 
            this.freqBindingSource.DataMember = "freq";
            this.freqBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "station";
            this.stationBindingSource.DataSource = this.studentDataSet;
            // 
            // freqTableAdapter
            // 
            this.freqTableAdapter.ClearBeforeFill = true;
            // 
            // stationTableAdapter
            // 
            this.stationTableAdapter.ClearBeforeFill = true;
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "owners";
            this.ownersBindingSource.DataSource = this.studentDataSet;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Операции с базой";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ant_information
            // 
            this.ant_information.AllowUserToAddRows = false;
            this.ant_information.AllowUserToDeleteRows = false;
            this.ant_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ant_information.Location = new System.Drawing.Point(0, 342);
            this.ant_information.Name = "ant_information";
            this.ant_information.ReadOnly = true;
            this.ant_information.Size = new System.Drawing.Size(1075, 122);
            this.ant_information.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Антенны:";
            // 
            // freqantinfBindingSource
            // 
            this.freqantinfBindingSource.DataMember = "freq_ant_inf";
            this.freqantinfBindingSource.DataSource = this.studentDataSet;
            // 
            // freq_ant_infTableAdapter
            // 
            this.freq_ant_infTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rich_res_tab);
            this.Controls.Add(this.agent_information);
            this.Controls.Add(this.agents);
            this.Name = "Form2";
            this.Text = "БД";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agent_information)).EndInit();
            this.rich_res_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freq_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.station_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ant_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqantinfBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView agents;
        private System.Windows.Forms.DataGridView agent_information;
        private System.Windows.Forms.TabControl rich_res_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView station_information;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView freq_information;
        private System.Windows.Forms.Label label2;
        private StudentDataSet studentDataSet;
        private StudentDataSetTableAdapters.freqTableAdapter freqTableAdapter;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private StudentDataSetTableAdapters.stationTableAdapter stationTableAdapter;
        private System.Windows.Forms.BindingSource freqBindingSource;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private StudentDataSetTableAdapters.ownersTableAdapter ownersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ant_information;
        private System.Windows.Forms.BindingSource freqantinfBindingSource;
        private StudentDataSetTableAdapters.freq_ant_infTableAdapter freq_ant_infTableAdapter;
    }
}