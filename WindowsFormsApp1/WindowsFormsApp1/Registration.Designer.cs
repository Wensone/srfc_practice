namespace WindowsFormsApp1
{
    partial class Registration
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
            this.reg_login = new System.Windows.Forms.TextBox();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.rega = new System.Windows.Forms.Button();
            this.user_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reg_login
            // 
            this.reg_login.Location = new System.Drawing.Point(41, 12);
            this.reg_login.Name = "reg_login";
            this.reg_login.Size = new System.Drawing.Size(100, 20);
            this.reg_login.TabIndex = 0;
            // 
            // reg_password
            // 
            this.reg_password.Location = new System.Drawing.Point(41, 38);
            this.reg_password.Name = "reg_password";
            this.reg_password.Size = new System.Drawing.Size(100, 20);
            this.reg_password.TabIndex = 1;
            // 
            // rega
            // 
            this.rega.Location = new System.Drawing.Point(41, 95);
            this.rega.Name = "rega";
            this.rega.Size = new System.Drawing.Size(100, 23);
            this.rega.TabIndex = 2;
            this.rega.Text = "Регистрация";
            this.rega.UseVisualStyleBackColor = true;
            this.rega.Click += new System.EventHandler(this.rega_Click);
            // 
            // user_type
            // 
            this.user_type.FormattingEnabled = true;
            this.user_type.Items.AddRange(new object[] {
            "0",
            "1"});
            this.user_type.Location = new System.Drawing.Point(41, 64);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(100, 21);
            this.user_type.TabIndex = 3;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 146);
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.rega);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.reg_login);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reg_login;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Button rega;
        private System.Windows.Forms.ComboBox user_type;
    }
}