namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.studentDataSet = new WindowsFormsApp1.StudentDataSet();
            this.studentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rclasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rclasTableAdapter = new WindowsFormsApp1.StudentDataSetTableAdapters.rclasTableAdapter();
            this.studentDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.freqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freqTableAdapter = new WindowsFormsApp1.StudentDataSetTableAdapters.freqTableAdapter();
            this.type = new System.Windows.Forms.ComboBox();
            this.table = new System.Windows.Forms.ComboBox();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.verification = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rclasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.rclasBindingSource.DataSource = this.studentDataSet;
            // 
            // rclasTableAdapter
            // 
            this.rclasTableAdapter.ClearBeforeFill = true;
            // 
            // studentDataSetBindingSource1
            // 
            this.studentDataSetBindingSource1.DataSource = this.studentDataSet;
            this.studentDataSetBindingSource1.Position = 0;
            // 
            // studentDataSetBindingSource2
            // 
            this.studentDataSetBindingSource2.DataSource = this.studentDataSet;
            this.studentDataSetBindingSource2.Position = 0;
            // 
            // freqBindingSource
            // 
            this.freqBindingSource.DataMember = "freq";
            this.freqBindingSource.DataSource = this.studentDataSetBindingSource2;
            // 
            // freqTableAdapter
            // 
            this.freqTableAdapter.ClearBeforeFill = true;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "РЭС",
            "РИЧ"});
            this.type.Location = new System.Drawing.Point(71, 7);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.TabIndex = 0;
            this.type.Text = "DB type";
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // table
            // 
            this.table.FormattingEnabled = true;
            this.table.Location = new System.Drawing.Point(71, 39);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(121, 21);
            this.table.TabIndex = 1;
            this.table.Text = "DB table";
            this.table.SelectedIndexChanged += new System.EventHandler(this.table_SelectedIndexChanged);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(71, 74);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(121, 20);
            this.login.TabIndex = 2;
            this.login.Tag = "";
            this.login.Text = "Login";
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(71, 102);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(121, 20);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // verification
            // 
            this.verification.Location = new System.Drawing.Point(71, 163);
            this.verification.Name = "verification";
            this.verification.Size = new System.Drawing.Size(121, 23);
            this.verification.TabIndex = 4;
            this.verification.Text = "Enter";
            this.verification.UseVisualStyleBackColor = true;
            this.verification.Click += new System.EventHandler(this.button_verification_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 260);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verification);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.table);
            this.Controls.Add(this.type);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rclasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource studentDataSetBindingSource;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource rclasBindingSource;
        private StudentDataSetTableAdapters.rclasTableAdapter rclasTableAdapter;
        private System.Windows.Forms.BindingSource studentDataSetBindingSource2;
        private System.Windows.Forms.BindingSource studentDataSetBindingSource1;
        private System.Windows.Forms.BindingSource freqBindingSource;
        private StudentDataSetTableAdapters.freqTableAdapter freqTableAdapter;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox table;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button verification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

