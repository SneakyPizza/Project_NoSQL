namespace UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_ForgotPassword = new System.Windows.Forms.Label();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.pnl_ForgotPassword = new System.Windows.Forms.Panel();
            this.pnl_ForgotPasswordCode = new System.Windows.Forms.Panel();
            this.pnl_ForgotPasswordNewPassword = new System.Windows.Forms.Panel();
            this.btn_ForgotPasswordConfirmNewPassword = new System.Windows.Forms.Button();
            this.lbl_ForgotPasswordNewPassword2 = new System.Windows.Forms.Label();
            this.lbl_ForgotPasswordNewPassword1 = new System.Windows.Forms.Label();
            this.tb_ForgotPasswordConfirm = new System.Windows.Forms.TextBox();
            this.tb_ForgotPasswordNew = new System.Windows.Forms.TextBox();
            this.btn_ForgotPasswordCodeConfirm = new System.Windows.Forms.Button();
            this.tb_ForgotPasswordCode = new System.Windows.Forms.TextBox();
            this.lbl_ForgotPasswordCode = new System.Windows.Forms.Label();
            this.btn_ForgotPasswordConfirm = new System.Windows.Forms.Button();
            this.lbl_ForgotPasswordEmail = new System.Windows.Forms.Label();
            this.tb_ForgotPassword = new System.Windows.Forms.TextBox();
            this.lbl_ForgotPasswordEmailText = new System.Windows.Forms.Label();
            this.btn_LoginReturn1 = new System.Windows.Forms.Button();
            this.btn_LoginReturn2 = new System.Windows.Forms.Button();
            this.btn_LoginReturn3 = new System.Windows.Forms.Button();
            this.pnl_Login.SuspendLayout();
            this.pnl_ForgotPassword.SuspendLayout();
            this.pnl_ForgotPasswordCode.SuspendLayout();
            this.pnl_ForgotPasswordNewPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Username.Location = new System.Drawing.Point(541, 280);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(206, 32);
            this.tb_Username.TabIndex = 0;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Password.Location = new System.Drawing.Point(541, 218);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(206, 32);
            this.tb_Password.TabIndex = 1;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Username.Location = new System.Drawing.Point(390, 225);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(101, 25);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Password.Location = new System.Drawing.Point(390, 287);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(95, 25);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password:";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(541, 345);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(137, 38);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_ForgotPassword
            // 
            this.lbl_ForgotPassword.AutoSize = true;
            this.lbl_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPassword.Location = new System.Drawing.Point(511, 445);
            this.lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            this.lbl_ForgotPassword.Size = new System.Drawing.Size(213, 21);
            this.lbl_ForgotPassword.TabIndex = 5;
            this.lbl_ForgotPassword.Text = "Forgot password? Click Here!";
            this.lbl_ForgotPassword.Click += new System.EventHandler(this.lbl_ForgotPassword_Click);
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.pnl_ForgotPassword);
            this.pnl_Login.Controls.Add(this.lbl_ForgotPassword);
            this.pnl_Login.Controls.Add(this.lbl_Username);
            this.pnl_Login.Controls.Add(this.tb_Username);
            this.pnl_Login.Controls.Add(this.btn_Login);
            this.pnl_Login.Controls.Add(this.lbl_Password);
            this.pnl_Login.Controls.Add(this.tb_Password);
            this.pnl_Login.Location = new System.Drawing.Point(0, 44);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1265, 638);
            this.pnl_Login.TabIndex = 6;
            // 
            // pnl_ForgotPassword
            // 
            this.pnl_ForgotPassword.Controls.Add(this.pnl_ForgotPasswordCode);
            this.pnl_ForgotPassword.Controls.Add(this.btn_ForgotPasswordConfirm);
            this.pnl_ForgotPassword.Controls.Add(this.lbl_ForgotPasswordEmail);
            this.pnl_ForgotPassword.Controls.Add(this.tb_ForgotPassword);
            this.pnl_ForgotPassword.Controls.Add(this.lbl_ForgotPasswordEmailText);
            this.pnl_ForgotPassword.Controls.Add(this.btn_LoginReturn1);
            this.pnl_ForgotPassword.Location = new System.Drawing.Point(12, 23);
            this.pnl_ForgotPassword.Name = "pnl_ForgotPassword";
            this.pnl_ForgotPassword.Size = new System.Drawing.Size(1240, 615);
            this.pnl_ForgotPassword.TabIndex = 6;
            // 
            // pnl_ForgotPasswordCode
            // 
            this.pnl_ForgotPasswordCode.Controls.Add(this.pnl_ForgotPasswordNewPassword);
            this.pnl_ForgotPasswordCode.Controls.Add(this.btn_ForgotPasswordCodeConfirm);
            this.pnl_ForgotPasswordCode.Controls.Add(this.tb_ForgotPasswordCode);
            this.pnl_ForgotPasswordCode.Controls.Add(this.lbl_ForgotPasswordCode);
            this.pnl_ForgotPasswordCode.Controls.Add(this.btn_LoginReturn2);
            this.pnl_ForgotPasswordCode.Location = new System.Drawing.Point(3, 14);
            this.pnl_ForgotPasswordCode.Name = "pnl_ForgotPasswordCode";
            this.pnl_ForgotPasswordCode.Size = new System.Drawing.Size(1221, 525);
            this.pnl_ForgotPasswordCode.TabIndex = 3;
            // 
            // pnl_ForgotPasswordNewPassword
            // 
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.btn_LoginReturn3);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.btn_ForgotPasswordConfirmNewPassword);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.lbl_ForgotPasswordNewPassword2);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.lbl_ForgotPasswordNewPassword1);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.tb_ForgotPasswordConfirm);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.tb_ForgotPasswordNew);
            this.pnl_ForgotPasswordNewPassword.Location = new System.Drawing.Point(3, 3);
            this.pnl_ForgotPasswordNewPassword.Name = "pnl_ForgotPasswordNewPassword";
            this.pnl_ForgotPasswordNewPassword.Size = new System.Drawing.Size(1215, 519);
            this.pnl_ForgotPasswordNewPassword.TabIndex = 3;
            // 
            // btn_ForgotPasswordConfirmNewPassword
            // 
            this.btn_ForgotPasswordConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ForgotPasswordConfirmNewPassword.Location = new System.Drawing.Point(482, 241);
            this.btn_ForgotPasswordConfirmNewPassword.Name = "btn_ForgotPasswordConfirmNewPassword";
            this.btn_ForgotPasswordConfirmNewPassword.Size = new System.Drawing.Size(137, 38);
            this.btn_ForgotPasswordConfirmNewPassword.TabIndex = 4;
            this.btn_ForgotPasswordConfirmNewPassword.Text = "Confirm";
            this.btn_ForgotPasswordConfirmNewPassword.UseVisualStyleBackColor = true;
            this.btn_ForgotPasswordConfirmNewPassword.Click += new System.EventHandler(this.btn_ForgotPasswordConfirmNewPassword_Click);
            // 
            // lbl_ForgotPasswordNewPassword2
            // 
            this.lbl_ForgotPasswordNewPassword2.AutoSize = true;
            this.lbl_ForgotPasswordNewPassword2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordNewPassword2.Location = new System.Drawing.Point(299, 192);
            this.lbl_ForgotPasswordNewPassword2.Name = "lbl_ForgotPasswordNewPassword2";
            this.lbl_ForgotPasswordNewPassword2.Size = new System.Drawing.Size(141, 21);
            this.lbl_ForgotPasswordNewPassword2.TabIndex = 3;
            this.lbl_ForgotPasswordNewPassword2.Text = "Confirm password:";
            // 
            // lbl_ForgotPasswordNewPassword1
            // 
            this.lbl_ForgotPasswordNewPassword1.AutoSize = true;
            this.lbl_ForgotPasswordNewPassword1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordNewPassword1.Location = new System.Drawing.Point(321, 140);
            this.lbl_ForgotPasswordNewPassword1.Name = "lbl_ForgotPasswordNewPassword1";
            this.lbl_ForgotPasswordNewPassword1.Size = new System.Drawing.Size(116, 21);
            this.lbl_ForgotPasswordNewPassword1.TabIndex = 2;
            this.lbl_ForgotPasswordNewPassword1.Text = "New password:";
            // 
            // tb_ForgotPasswordConfirm
            // 
            this.tb_ForgotPasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPasswordConfirm.Location = new System.Drawing.Point(462, 186);
            this.tb_ForgotPasswordConfirm.Name = "tb_ForgotPasswordConfirm";
            this.tb_ForgotPasswordConfirm.PasswordChar = '*';
            this.tb_ForgotPasswordConfirm.Size = new System.Drawing.Size(174, 29);
            this.tb_ForgotPasswordConfirm.TabIndex = 1;
            // 
            // tb_ForgotPasswordNew
            // 
            this.tb_ForgotPasswordNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPasswordNew.Location = new System.Drawing.Point(462, 132);
            this.tb_ForgotPasswordNew.Name = "tb_ForgotPasswordNew";
            this.tb_ForgotPasswordNew.PasswordChar = '*';
            this.tb_ForgotPasswordNew.Size = new System.Drawing.Size(174, 29);
            this.tb_ForgotPasswordNew.TabIndex = 0;
            // 
            // btn_ForgotPasswordCodeConfirm
            // 
            this.btn_ForgotPasswordCodeConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ForgotPasswordCodeConfirm.Location = new System.Drawing.Point(485, 262);
            this.btn_ForgotPasswordCodeConfirm.Name = "btn_ForgotPasswordCodeConfirm";
            this.btn_ForgotPasswordCodeConfirm.Size = new System.Drawing.Size(137, 38);
            this.btn_ForgotPasswordCodeConfirm.TabIndex = 2;
            this.btn_ForgotPasswordCodeConfirm.Text = "Confirm";
            this.btn_ForgotPasswordCodeConfirm.UseVisualStyleBackColor = true;
            this.btn_ForgotPasswordCodeConfirm.Click += new System.EventHandler(this.btn_ForgotPasswordCodeConfirm_Click);
            // 
            // tb_ForgotPasswordCode
            // 
            this.tb_ForgotPasswordCode.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPasswordCode.Location = new System.Drawing.Point(465, 224);
            this.tb_ForgotPasswordCode.Name = "tb_ForgotPasswordCode";
            this.tb_ForgotPasswordCode.Size = new System.Drawing.Size(174, 32);
            this.tb_ForgotPasswordCode.TabIndex = 1;
            // 
            // lbl_ForgotPasswordCode
            // 
            this.lbl_ForgotPasswordCode.AutoSize = true;
            this.lbl_ForgotPasswordCode.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordCode.Location = new System.Drawing.Point(375, 227);
            this.lbl_ForgotPasswordCode.Name = "lbl_ForgotPasswordCode";
            this.lbl_ForgotPasswordCode.Size = new System.Drawing.Size(65, 25);
            this.lbl_ForgotPasswordCode.TabIndex = 0;
            this.lbl_ForgotPasswordCode.Text = "Code: ";
            // 
            // btn_ForgotPasswordConfirm
            // 
            this.btn_ForgotPasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ForgotPasswordConfirm.Location = new System.Drawing.Point(379, 168);
            this.btn_ForgotPasswordConfirm.Name = "btn_ForgotPasswordConfirm";
            this.btn_ForgotPasswordConfirm.Size = new System.Drawing.Size(137, 38);
            this.btn_ForgotPasswordConfirm.TabIndex = 2;
            this.btn_ForgotPasswordConfirm.Text = "Confirm";
            this.btn_ForgotPasswordConfirm.UseVisualStyleBackColor = true;
            this.btn_ForgotPasswordConfirm.Click += new System.EventHandler(this.btn_ForgotPasswordConfirm_Click);
            // 
            // lbl_ForgotPasswordEmail
            // 
            this.lbl_ForgotPasswordEmail.AutoSize = true;
            this.lbl_ForgotPasswordEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordEmail.Location = new System.Drawing.Point(232, 133);
            this.lbl_ForgotPasswordEmail.Name = "lbl_ForgotPasswordEmail";
            this.lbl_ForgotPasswordEmail.Size = new System.Drawing.Size(67, 25);
            this.lbl_ForgotPasswordEmail.TabIndex = 1;
            this.lbl_ForgotPasswordEmail.Text = "Email: ";
            // 
            // tb_ForgotPassword
            // 
            this.tb_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPassword.Location = new System.Drawing.Point(305, 130);
            this.tb_ForgotPassword.Name = "tb_ForgotPassword";
            this.tb_ForgotPassword.Size = new System.Drawing.Size(302, 32);
            this.tb_ForgotPassword.TabIndex = 0;
            // 
            // lbl_ForgotPasswordEmailText
            // 
            this.lbl_ForgotPasswordEmailText.AutoSize = true;
            this.lbl_ForgotPasswordEmailText.Location = new System.Drawing.Point(305, 101);
            this.lbl_ForgotPasswordEmailText.Name = "lbl_ForgotPasswordEmailText";
            this.lbl_ForgotPasswordEmailText.Size = new System.Drawing.Size(312, 15);
            this.lbl_ForgotPasswordEmailText.TabIndex = 4;
            this.lbl_ForgotPasswordEmailText.Text = "Please enter the emailadress associated with your account";
            // 
            // btn_LoginReturn1
            // 
            this.btn_LoginReturn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginReturn1.Location = new System.Drawing.Point(30, 28);
            this.btn_LoginReturn1.Name = "btn_LoginReturn1";
            this.btn_LoginReturn1.Size = new System.Drawing.Size(137, 38);
            this.btn_LoginReturn1.TabIndex = 4;
            this.btn_LoginReturn1.Text = "Return";
            this.btn_LoginReturn1.UseVisualStyleBackColor = true;
            this.btn_LoginReturn1.Click += new System.EventHandler(this.ReturnToLoginEvent);
            // 
            // btn_LoginReturn2
            // 
            this.btn_LoginReturn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginReturn2.Location = new System.Drawing.Point(17, 14);
            this.btn_LoginReturn2.Name = "btn_LoginReturn2";
            this.btn_LoginReturn2.Size = new System.Drawing.Size(137, 38);
            this.btn_LoginReturn2.TabIndex = 5;
            this.btn_LoginReturn2.Text = "Return";
            this.btn_LoginReturn2.UseVisualStyleBackColor = true;
            // 
            // btn_LoginReturn3
            // 
            this.btn_LoginReturn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginReturn3.Location = new System.Drawing.Point(7, 18);
            this.btn_LoginReturn3.Name = "btn_LoginReturn3";
            this.btn_LoginReturn3.Size = new System.Drawing.Size(137, 38);
            this.btn_LoginReturn3.TabIndex = 6;
            this.btn_LoginReturn3.Text = "Return";
            this.btn_LoginReturn3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_Login);
            this.Name = "MainForm";
            this.Text = "Ticket System";
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.pnl_ForgotPassword.ResumeLayout(false);
            this.pnl_ForgotPassword.PerformLayout();
            this.pnl_ForgotPasswordCode.ResumeLayout(false);
            this.pnl_ForgotPasswordCode.PerformLayout();
            this.pnl_ForgotPasswordNewPassword.ResumeLayout(false);
            this.pnl_ForgotPasswordNewPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_ForgotPassword;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Panel pnl_ForgotPassword;
        private System.Windows.Forms.Button btn_ForgotPasswordConfirm;
        private System.Windows.Forms.Label lbl_ForgotPasswordEmail;
        private System.Windows.Forms.TextBox tb_ForgotPassword;
        private System.Windows.Forms.Panel pnl_ForgotPasswordCode;
        private System.Windows.Forms.Button btn_ForgotPasswordCodeConfirm;
        private System.Windows.Forms.TextBox tb_ForgotPasswordCode;
        private System.Windows.Forms.Label lbl_ForgotPasswordCode;
        private System.Windows.Forms.Label lbl_ForgotPasswordEmailText;
        private System.Windows.Forms.Panel pnl_ForgotPasswordNewPassword;
        private System.Windows.Forms.Button btn_ForgotPasswordConfirmNewPassword;
        private System.Windows.Forms.Label lbl_ForgotPasswordNewPassword2;
        private System.Windows.Forms.Label lbl_ForgotPasswordNewPassword1;
        private System.Windows.Forms.TextBox tb_ForgotPasswordConfirm;
        private System.Windows.Forms.TextBox tb_ForgotPasswordNew;
        private System.Windows.Forms.Button btn_LoginReturn1;
        private System.Windows.Forms.Button btn_LoginReturn3;
        private System.Windows.Forms.Button btn_LoginReturn2;
    }
}

