
namespace UI
{
    partial class NewMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMainForm));
            this.pnl_DashboardOptions = new System.Windows.Forms.Panel();
            this.btn_ManageUsers = new System.Windows.Forms.Button();
            this.btn_Tickets = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.pictureBox_homeButton = new System.Windows.Forms.PictureBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ForgotPassword = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pnl_DashboardOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_homeButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_DashboardOptions
            // 
            this.pnl_DashboardOptions.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_DashboardOptions.Controls.Add(this.btn_ManageUsers);
            this.pnl_DashboardOptions.Controls.Add(this.btn_Tickets);
            this.pnl_DashboardOptions.Controls.Add(this.btn_Dashboard);
            this.pnl_DashboardOptions.Controls.Add(this.pictureBox_homeButton);
            this.pnl_DashboardOptions.Location = new System.Drawing.Point(1, 0);
            this.pnl_DashboardOptions.Name = "pnl_DashboardOptions";
            this.pnl_DashboardOptions.Size = new System.Drawing.Size(1174, 100);
            this.pnl_DashboardOptions.TabIndex = 15;
            // 
            // btn_ManageUsers
            // 
            this.btn_ManageUsers.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_ManageUsers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ManageUsers.Location = new System.Drawing.Point(862, 12);
            this.btn_ManageUsers.Name = "btn_ManageUsers";
            this.btn_ManageUsers.Size = new System.Drawing.Size(269, 80);
            this.btn_ManageUsers.TabIndex = 3;
            this.btn_ManageUsers.Text = "Manage Users\r\n";
            this.btn_ManageUsers.UseVisualStyleBackColor = false;
            // 
            // btn_Tickets
            // 
            this.btn_Tickets.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Tickets.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Tickets.Location = new System.Drawing.Point(544, 12);
            this.btn_Tickets.Name = "btn_Tickets";
            this.btn_Tickets.Size = new System.Drawing.Size(273, 80);
            this.btn_Tickets.TabIndex = 2;
            this.btn_Tickets.Text = "Manage Tickets";
            this.btn_Tickets.UseVisualStyleBackColor = false;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Dashboard.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Dashboard.Location = new System.Drawing.Point(226, 12);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(272, 80);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox_homeButton
            // 
            this.pictureBox_homeButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_homeButton.Image")));
            this.pictureBox_homeButton.Location = new System.Drawing.Point(11, 6);
            this.pictureBox_homeButton.Name = "pictureBox_homeButton";
            this.pictureBox_homeButton.Size = new System.Drawing.Size(86, 86);
            this.pictureBox_homeButton.TabIndex = 4;
            this.pictureBox_homeButton.TabStop = false;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Password.Location = new System.Drawing.Point(78, 289);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(116, 32);
            this.lbl_Password.TabIndex = 14;
            this.lbl_Password.Text = "Password:";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Password.Location = new System.Drawing.Point(200, 289);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(235, 39);
            this.tb_Password.TabIndex = 13;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Username.Location = new System.Drawing.Point(68, 219);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(126, 32);
            this.lbl_Username.TabIndex = 12;
            this.lbl_Username.Text = "Username:";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Username.Location = new System.Drawing.Point(200, 219);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(235, 39);
            this.tb_Username.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(545, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 771);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 155);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome to our login portal.\r\nFrom here you can login to The Garden Group \r\nManag" +
    "ement System.\r\n\r\n.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 176);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ForgotPassword
            // 
            this.lbl_ForgotPassword.AutoSize = true;
            this.lbl_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPassword.Location = new System.Drawing.Point(185, 439);
            this.lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            this.lbl_ForgotPassword.Size = new System.Drawing.Size(267, 28);
            this.lbl_ForgotPassword.TabIndex = 18;
            this.lbl_ForgotPassword.Text = "Forgot password? Click Here!";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(214, 357);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(188, 59);
            this.btn_Login.TabIndex = 17;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // NewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1144, 731);
            this.Controls.Add(this.pnl_DashboardOptions);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_ForgotPassword);
            this.Controls.Add(this.btn_Login);
            this.Name = "NewMainForm";
            this.Text = "NewMainForm";
            this.pnl_DashboardOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_homeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_DashboardOptions;
        private System.Windows.Forms.Button btn_ManageUsers;
        private System.Windows.Forms.Button btn_Tickets;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox_homeButton;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ForgotPassword;
        private System.Windows.Forms.Button btn_Login;
    }
}