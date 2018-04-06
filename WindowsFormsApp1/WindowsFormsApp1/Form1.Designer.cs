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
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.verification = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.Button();
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
            // login
            // 
            this.login.Location = new System.Drawing.Point(47, 7);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(148, 20);
            this.login.TabIndex = 2;
            this.login.Tag = "";
            this.login.Text = "Login";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(47, 35);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(148, 20);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // verification
            // 
            this.verification.Location = new System.Drawing.Point(104, 61);
            this.verification.Name = "verification";
            this.verification.Size = new System.Drawing.Size(91, 23);
            this.verification.TabIndex = 4;
            this.verification.Text = "Авторизация";
            this.verification.UseVisualStyleBackColor = true;
            this.verification.Click += new System.EventHandler(this.button_verification_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(9, 61);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(91, 23);
            this.registration.TabIndex = 7;
            this.registration.Text = "Регистрация";
            this.registration.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 91);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
            this.Controls.Add(this.verification);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "Авторизация";
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
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button verification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registration;
    }
}

