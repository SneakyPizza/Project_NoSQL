namespace UI
{
    partial class FormYornie
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.circleProgressControl1 = new UI.CircleProgressControl();
            this.tb_NewPassword = new System.Windows.Forms.TextBox();
            this.tb_NewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btn_ConfirmNewPassword = new System.Windows.Forms.Button();
            this.btn_CheckCode = new System.Windows.Forms.Button();
            this.tb_CheckCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(128, 187);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(70, 17);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(128, 219);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(67, 17);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password:";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(198, 187);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(100, 25);
            this.tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(198, 220);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(100, 25);
            this.tb_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(209, 253);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 26);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // circleProgressControl1
            // 
            this.circleProgressControl1.CurrentValue = 20D;
            this.circleProgressControl1.FillColor = System.Drawing.Color.White;
            this.circleProgressControl1.Location = new System.Drawing.Point(9, 197);
            this.circleProgressControl1.MaxValue = 100D;
            this.circleProgressControl1.Name = "circleProgressControl1";
            this.circleProgressControl1.ProgressColor = System.Drawing.Color.Orange;
            this.circleProgressControl1.Size = new System.Drawing.Size(113, 122);
            this.circleProgressControl1.TabIndex = 5;
            // 
            // tb_NewPassword
            // 
            this.tb_NewPassword.Location = new System.Drawing.Point(315, 31);
            this.tb_NewPassword.Name = "tb_NewPassword";
            this.tb_NewPassword.Size = new System.Drawing.Size(110, 25);
            this.tb_NewPassword.TabIndex = 6;
            // 
            // tb_NewPasswordConfirm
            // 
            this.tb_NewPasswordConfirm.Location = new System.Drawing.Point(315, 63);
            this.tb_NewPasswordConfirm.Name = "tb_NewPasswordConfirm";
            this.tb_NewPasswordConfirm.Size = new System.Drawing.Size(110, 25);
            this.tb_NewPasswordConfirm.TabIndex = 7;
            // 
            // btn_ConfirmNewPassword
            // 
            this.btn_ConfirmNewPassword.Location = new System.Drawing.Point(328, 94);
            this.btn_ConfirmNewPassword.Name = "btn_ConfirmNewPassword";
            this.btn_ConfirmNewPassword.Size = new System.Drawing.Size(83, 25);
            this.btn_ConfirmNewPassword.TabIndex = 8;
            this.btn_ConfirmNewPassword.Text = "Confirm";
            this.btn_ConfirmNewPassword.UseVisualStyleBackColor = true;
            this.btn_ConfirmNewPassword.Click += new System.EventHandler(this.btn_ConfirmNewPassword_Click);
            // 
            // btn_CheckCode
            // 
            this.btn_CheckCode.Location = new System.Drawing.Point(21, 43);
            this.btn_CheckCode.Name = "btn_CheckCode";
            this.btn_CheckCode.Size = new System.Drawing.Size(83, 25);
            this.btn_CheckCode.TabIndex = 9;
            this.btn_CheckCode.Text = "Check code";
            this.btn_CheckCode.UseVisualStyleBackColor = true;
            this.btn_CheckCode.Click += new System.EventHandler(this.btn_CheckCode_Click);
            // 
            // tb_CheckCode
            // 
            this.tb_CheckCode.Location = new System.Drawing.Point(12, 12);
            this.tb_CheckCode.Name = "tb_CheckCode";
            this.tb_CheckCode.Size = new System.Drawing.Size(110, 25);
            this.tb_CheckCode.TabIndex = 10;
            // 
            // FormYornie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 340);
            this.Controls.Add(this.tb_CheckCode);
            this.Controls.Add(this.btn_CheckCode);
            this.Controls.Add(this.btn_ConfirmNewPassword);
            this.Controls.Add(this.tb_NewPasswordConfirm);
            this.Controls.Add(this.tb_NewPassword);
            this.Controls.Add(this.circleProgressControl1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Name = "FormYornie";
            this.Text = "FormYornie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
        private CircleProgressControl circleProgressControl1;
        private System.Windows.Forms.TextBox tb_NewPassword;
        private System.Windows.Forms.TextBox tb_NewPasswordConfirm;
        private System.Windows.Forms.Button btn_ConfirmNewPassword;
        private System.Windows.Forms.Button btn_CheckCode;
        private System.Windows.Forms.TextBox tb_CheckCode;
    }
}