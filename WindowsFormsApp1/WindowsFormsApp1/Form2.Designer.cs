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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentDataSet = new WindowsFormsApp1.StudentDataSet();
            this.studentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rclasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rclasTableAdapter = new WindowsFormsApp1.StudentDataSetTableAdapters.rclasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSHPIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIGITANALOGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rclasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rclassDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.nSHPIDataGridViewTextBoxColumn,
            this.dIGITANALOGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rclasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataSetBindingSource
            // 
            this.studentDataSetBindingSource.DataSource = this.studentDataSet;
            this.studentDataSetBindingSource.Position = 0;
            // 
            // rclasBindingSource
            // 
            this.rclasBindingSource.DataMember = "rclas";
            this.rclasBindingSource.DataSource = this.studentDataSetBindingSource;
            // 
            // rclasTableAdapter
            // 
            this.rclasTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rclassDataGridViewTextBoxColumn
            // 
            this.rclassDataGridViewTextBoxColumn.DataPropertyName = "Rclass";
            this.rclassDataGridViewTextBoxColumn.HeaderText = "Rclass";
            this.rclassDataGridViewTextBoxColumn.Name = "rclassDataGridViewTextBoxColumn";
            this.rclassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nSHPIDataGridViewTextBoxColumn
            // 
            this.nSHPIDataGridViewTextBoxColumn.DataPropertyName = "NSHPI";
            this.nSHPIDataGridViewTextBoxColumn.HeaderText = "NSHPI";
            this.nSHPIDataGridViewTextBoxColumn.Name = "nSHPIDataGridViewTextBoxColumn";
            this.nSHPIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIGITANALOGDataGridViewTextBoxColumn
            // 
            this.dIGITANALOGDataGridViewTextBoxColumn.DataPropertyName = "DIGIT_ANALOG";
            this.dIGITANALOGDataGridViewTextBoxColumn.HeaderText = "DIGIT_ANALOG";
            this.dIGITANALOGDataGridViewTextBoxColumn.Name = "dIGITANALOGDataGridViewTextBoxColumn";
            this.dIGITANALOGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitfromapp);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rclasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentDataSetBindingSource;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource rclasBindingSource;
        private StudentDataSetTableAdapters.rclasTableAdapter rclasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSHPIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIGITANALOGDataGridViewTextBoxColumn;
    }
}