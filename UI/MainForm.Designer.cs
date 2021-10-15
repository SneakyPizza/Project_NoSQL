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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_ForgotPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cpc_DashboardOvertimeTickets = new UI.CircleProgressControl();
            this.lbl_DashboardOvertimeText = new System.Windows.Forms.Label();
            this.lbl_DashboardUnresolvedText = new System.Windows.Forms.Label();
            this.cpc_DashboardUnresolvedTickets = new UI.CircleProgressControl();
            this.pnl_ForgotPasswordNewPassword = new System.Windows.Forms.Panel();
            this.pic_LoginReturn3 = new System.Windows.Forms.PictureBox();
            this.btn_ForgotPasswordConfirmNewPassword = new System.Windows.Forms.Button();
            this.lbl_ForgotPasswordNewPassword2 = new System.Windows.Forms.Label();
            this.lbl_ForgotPasswordNewPassword1 = new System.Windows.Forms.Label();
            this.tb_ForgotPasswordConfirm = new System.Windows.Forms.TextBox();
            this.tb_ForgotPasswordNew = new System.Windows.Forms.TextBox();
            this.pic_LoginReturn2 = new System.Windows.Forms.PictureBox();
            this.pnl_DashboardOptions = new System.Windows.Forms.Panel();
            this.btn_ManageUsers = new System.Windows.Forms.Button();
            this.btn_Tickets = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.pictureBox_homeButton = new System.Windows.Forms.PictureBox();
            this.pnl_ForgotPassword = new System.Windows.Forms.Panel();
            this.pic_LoginReturn = new System.Windows.Forms.PictureBox();
            this.btn_ForgotPasswordConfirm = new System.Windows.Forms.Button();
            this.lbl_ForgotPasswordEmail = new System.Windows.Forms.Label();
            this.tb_ForgotPassword = new System.Windows.Forms.TextBox();
            this.lbl_ForgotPasswordEmailText = new System.Windows.Forms.Label();
            this.lbl_ForgotPasswordCode = new System.Windows.Forms.Label();
            this.pnl_ForgotPasswordCode = new System.Windows.Forms.Panel();
            this.btn_ForgotPasswordCodeConfirm = new System.Windows.Forms.Button();
            this.tb_ForgotPasswordCode = new System.Windows.Forms.TextBox();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_Login.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_ForgotPasswordNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoginReturn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoginReturn2)).BeginInit();
            this.pnl_DashboardOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_homeButton)).BeginInit();
            this.pnl_ForgotPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoginReturn)).BeginInit();
            this.pnl_ForgotPasswordCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.pnl_Login);
            this.pnl_Dashboard.Controls.Add(this.cpc_DashboardOvertimeTickets);
            this.pnl_Dashboard.Controls.Add(this.lbl_DashboardOvertimeText);
            this.pnl_Dashboard.Controls.Add(this.lbl_DashboardUnresolvedText);
            this.pnl_Dashboard.Controls.Add(this.cpc_DashboardUnresolvedTickets);
            this.pnl_Dashboard.Location = new System.Drawing.Point(91, 35);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1143, 629);
            this.pnl_Dashboard.TabIndex = 22;
            this.pnl_Dashboard.Visible = false;
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.btn_Login);
            this.pnl_Login.Controls.Add(this.tb_Username);
            this.pnl_Login.Controls.Add(this.lbl_Username);
            this.pnl_Login.Controls.Add(this.tb_Password);
            this.pnl_Login.Controls.Add(this.lbl_Password);
            this.pnl_Login.Controls.Add(this.lbl_ForgotPassword);
            this.pnl_Login.Controls.Add(this.panel2);
            this.pnl_Login.Location = new System.Drawing.Point(271, 340);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1146, 730);
            this.pnl_Login.TabIndex = 9;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(238, 353);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(188, 59);
            this.btn_Login.TabIndex = 17;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Username.Location = new System.Drawing.Point(214, 219);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(235, 39);
            this.tb_Username.TabIndex = 11;
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
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Password.Location = new System.Drawing.Point(214, 286);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(235, 39);
            this.tb_Password.TabIndex = 13;
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
            // lbl_ForgotPassword
            // 
            this.lbl_ForgotPassword.AutoSize = true;
            this.lbl_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPassword.Location = new System.Drawing.Point(198, 433);
            this.lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            this.lbl_ForgotPassword.Size = new System.Drawing.Size(267, 28);
            this.lbl_ForgotPassword.TabIndex = 18;
            this.lbl_ForgotPassword.Text = "Forgot password? Click Here!";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 176);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // cpc_DashboardOvertimeTickets
            // 
            this.cpc_DashboardOvertimeTickets.CurrentValue = 50D;
            this.cpc_DashboardOvertimeTickets.FillColor = System.Drawing.Color.White;
            this.cpc_DashboardOvertimeTickets.Location = new System.Drawing.Point(723, 155);
            this.cpc_DashboardOvertimeTickets.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cpc_DashboardOvertimeTickets.MaxValue = 100D;
            this.cpc_DashboardOvertimeTickets.Name = "cpc_DashboardOvertimeTickets";
            this.cpc_DashboardOvertimeTickets.ProgressColor = System.Drawing.Color.Orange;
            this.cpc_DashboardOvertimeTickets.Size = new System.Drawing.Size(240, 280);
            this.cpc_DashboardOvertimeTickets.TabIndex = 8;
            // 
            // lbl_DashboardOvertimeText
            // 
            this.lbl_DashboardOvertimeText.AutoSize = true;
            this.lbl_DashboardOvertimeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DashboardOvertimeText.Location = new System.Drawing.Point(673, 105);
            this.lbl_DashboardOvertimeText.Name = "lbl_DashboardOvertimeText";
            this.lbl_DashboardOvertimeText.Size = new System.Drawing.Size(163, 28);
            this.lbl_DashboardOvertimeText.TabIndex = 7;
            this.lbl_DashboardOvertimeText.Text = "Overtime tickets: ";
            // 
            // lbl_DashboardUnresolvedText
            // 
            this.lbl_DashboardUnresolvedText.AutoSize = true;
            this.lbl_DashboardUnresolvedText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DashboardUnresolvedText.Location = new System.Drawing.Point(12, 97);
            this.lbl_DashboardUnresolvedText.Name = "lbl_DashboardUnresolvedText";
            this.lbl_DashboardUnresolvedText.Size = new System.Drawing.Size(181, 28);
            this.lbl_DashboardUnresolvedText.TabIndex = 6;
            this.lbl_DashboardUnresolvedText.Text = "Unresolved tickets: ";
            // 
            // cpc_DashboardUnresolvedTickets
            // 
            this.cpc_DashboardUnresolvedTickets.CurrentValue = 50D;
            this.cpc_DashboardUnresolvedTickets.FillColor = System.Drawing.Color.White;
            this.cpc_DashboardUnresolvedTickets.Location = new System.Drawing.Point(71, 133);
            this.cpc_DashboardUnresolvedTickets.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cpc_DashboardUnresolvedTickets.MaxValue = 100D;
            this.cpc_DashboardUnresolvedTickets.Name = "cpc_DashboardUnresolvedTickets";
            this.cpc_DashboardUnresolvedTickets.ProgressColor = System.Drawing.Color.Orange;
            this.cpc_DashboardUnresolvedTickets.Size = new System.Drawing.Size(240, 280);
            this.cpc_DashboardUnresolvedTickets.TabIndex = 5;
            // 
            // pnl_ForgotPasswordNewPassword
            // 
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.pic_LoginReturn3);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.btn_ForgotPasswordConfirmNewPassword);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.lbl_ForgotPasswordNewPassword2);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.lbl_ForgotPasswordNewPassword1);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.tb_ForgotPasswordConfirm);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.tb_ForgotPasswordNew);
            this.pnl_ForgotPasswordNewPassword.Location = new System.Drawing.Point(135, 88);
            this.pnl_ForgotPasswordNewPassword.Name = "pnl_ForgotPasswordNewPassword";
            this.pnl_ForgotPasswordNewPassword.Size = new System.Drawing.Size(1134, 620);
            this.pnl_ForgotPasswordNewPassword.TabIndex = 20;
            this.pnl_ForgotPasswordNewPassword.Visible = false;
            // 
            // pic_LoginReturn3
            // 
            this.pic_LoginReturn3.Image = ((System.Drawing.Image)(resources.GetObject("pic_LoginReturn3.Image")));
            this.pic_LoginReturn3.Location = new System.Drawing.Point(3, 4);
            this.pic_LoginReturn3.Name = "pic_LoginReturn3";
            this.pic_LoginReturn3.Size = new System.Drawing.Size(48, 55);
            this.pic_LoginReturn3.TabIndex = 10;
            this.pic_LoginReturn3.TabStop = false;
            // 
            // btn_ForgotPasswordConfirmNewPassword
            // 
            this.btn_ForgotPasswordConfirmNewPassword.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ForgotPasswordConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ForgotPasswordConfirmNewPassword.Location = new System.Drawing.Point(561, 352);
            this.btn_ForgotPasswordConfirmNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ForgotPasswordConfirmNewPassword.Name = "btn_ForgotPasswordConfirmNewPassword";
            this.btn_ForgotPasswordConfirmNewPassword.Size = new System.Drawing.Size(157, 51);
            this.btn_ForgotPasswordConfirmNewPassword.TabIndex = 9;
            this.btn_ForgotPasswordConfirmNewPassword.Text = "Confirm";
            this.btn_ForgotPasswordConfirmNewPassword.UseVisualStyleBackColor = false;
            // 
            // lbl_ForgotPasswordNewPassword2
            // 
            this.lbl_ForgotPasswordNewPassword2.AutoSize = true;
            this.lbl_ForgotPasswordNewPassword2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordNewPassword2.Location = new System.Drawing.Point(352, 287);
            this.lbl_ForgotPasswordNewPassword2.Name = "lbl_ForgotPasswordNewPassword2";
            this.lbl_ForgotPasswordNewPassword2.Size = new System.Drawing.Size(174, 28);
            this.lbl_ForgotPasswordNewPassword2.TabIndex = 8;
            this.lbl_ForgotPasswordNewPassword2.Text = "Confirm password:";
            // 
            // lbl_ForgotPasswordNewPassword1
            // 
            this.lbl_ForgotPasswordNewPassword1.AutoSize = true;
            this.lbl_ForgotPasswordNewPassword1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordNewPassword1.Location = new System.Drawing.Point(377, 218);
            this.lbl_ForgotPasswordNewPassword1.Name = "lbl_ForgotPasswordNewPassword1";
            this.lbl_ForgotPasswordNewPassword1.Size = new System.Drawing.Size(143, 28);
            this.lbl_ForgotPasswordNewPassword1.TabIndex = 7;
            this.lbl_ForgotPasswordNewPassword1.Text = "New password:";
            // 
            // tb_ForgotPasswordConfirm
            // 
            this.tb_ForgotPasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPasswordConfirm.Location = new System.Drawing.Point(538, 279);
            this.tb_ForgotPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ForgotPasswordConfirm.Name = "tb_ForgotPasswordConfirm";
            this.tb_ForgotPasswordConfirm.PasswordChar = '*';
            this.tb_ForgotPasswordConfirm.Size = new System.Drawing.Size(198, 34);
            this.tb_ForgotPasswordConfirm.TabIndex = 6;
            // 
            // tb_ForgotPasswordNew
            // 
            this.tb_ForgotPasswordNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPasswordNew.Location = new System.Drawing.Point(538, 207);
            this.tb_ForgotPasswordNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ForgotPasswordNew.Name = "tb_ForgotPasswordNew";
            this.tb_ForgotPasswordNew.PasswordChar = '*';
            this.tb_ForgotPasswordNew.Size = new System.Drawing.Size(198, 34);
            this.tb_ForgotPasswordNew.TabIndex = 5;
            // 
            // pic_LoginReturn2
            // 
            this.pic_LoginReturn2.Image = ((System.Drawing.Image)(resources.GetObject("pic_LoginReturn2.Image")));
            this.pic_LoginReturn2.Location = new System.Drawing.Point(1, 4);
            this.pic_LoginReturn2.Name = "pic_LoginReturn2";
            this.pic_LoginReturn2.Size = new System.Drawing.Size(53, 50);
            this.pic_LoginReturn2.TabIndex = 0;
            this.pic_LoginReturn2.TabStop = false;
            // 
            // pnl_DashboardOptions
            // 
            this.pnl_DashboardOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnl_DashboardOptions.Controls.Add(this.btn_ManageUsers);
            this.pnl_DashboardOptions.Controls.Add(this.btn_Tickets);
            this.pnl_DashboardOptions.Controls.Add(this.btn_Dashboard);
            this.pnl_DashboardOptions.Controls.Add(this.pictureBox_homeButton);
            this.pnl_DashboardOptions.Location = new System.Drawing.Point(136, 88);
            this.pnl_DashboardOptions.Name = "pnl_DashboardOptions";
            this.pnl_DashboardOptions.Size = new System.Drawing.Size(1174, 100);
            this.pnl_DashboardOptions.TabIndex = 23;
            this.pnl_DashboardOptions.Visible = false;
            // 
            // btn_ManageUsers
            // 
            this.btn_ManageUsers.BackColor = System.Drawing.Color.DarkSeaGreen;
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
            this.btn_Dashboard.Location = new System.Drawing.Point(213, 12);
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
            // pnl_ForgotPassword
            // 
            this.pnl_ForgotPassword.Controls.Add(this.pic_LoginReturn);
            this.pnl_ForgotPassword.Controls.Add(this.btn_ForgotPasswordConfirm);
            this.pnl_ForgotPassword.Controls.Add(this.lbl_ForgotPasswordEmail);
            this.pnl_ForgotPassword.Controls.Add(this.tb_ForgotPassword);
            this.pnl_ForgotPassword.Controls.Add(this.lbl_ForgotPasswordEmailText);
            this.pnl_ForgotPassword.Location = new System.Drawing.Point(136, 186);
            this.pnl_ForgotPassword.Name = "pnl_ForgotPassword";
            this.pnl_ForgotPassword.Size = new System.Drawing.Size(1146, 635);
            this.pnl_ForgotPassword.TabIndex = 24;
            this.pnl_ForgotPassword.Visible = false;
            // 
            // pic_LoginReturn
            // 
            this.pic_LoginReturn.Image = ((System.Drawing.Image)(resources.GetObject("pic_LoginReturn.Image")));
            this.pic_LoginReturn.Location = new System.Drawing.Point(3, 8);
            this.pic_LoginReturn.Name = "pic_LoginReturn";
            this.pic_LoginReturn.Size = new System.Drawing.Size(71, 54);
            this.pic_LoginReturn.TabIndex = 9;
            this.pic_LoginReturn.TabStop = false;
            // 
            // btn_ForgotPasswordConfirm
            // 
            this.btn_ForgotPasswordConfirm.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ForgotPasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ForgotPasswordConfirm.Location = new System.Drawing.Point(470, 319);
            this.btn_ForgotPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ForgotPasswordConfirm.Name = "btn_ForgotPasswordConfirm";
            this.btn_ForgotPasswordConfirm.Size = new System.Drawing.Size(218, 104);
            this.btn_ForgotPasswordConfirm.TabIndex = 7;
            this.btn_ForgotPasswordConfirm.Text = "Confirm";
            this.btn_ForgotPasswordConfirm.UseVisualStyleBackColor = false;
            // 
            // lbl_ForgotPasswordEmail
            // 
            this.lbl_ForgotPasswordEmail.AutoSize = true;
            this.lbl_ForgotPasswordEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordEmail.Location = new System.Drawing.Point(253, 237);
            this.lbl_ForgotPasswordEmail.Name = "lbl_ForgotPasswordEmail";
            this.lbl_ForgotPasswordEmail.Size = new System.Drawing.Size(83, 32);
            this.lbl_ForgotPasswordEmail.TabIndex = 6;
            this.lbl_ForgotPasswordEmail.Text = "Email: ";
            // 
            // tb_ForgotPassword
            // 
            this.tb_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPassword.Location = new System.Drawing.Point(403, 230);
            this.tb_ForgotPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ForgotPassword.Name = "tb_ForgotPassword";
            this.tb_ForgotPassword.Size = new System.Drawing.Size(345, 39);
            this.tb_ForgotPassword.TabIndex = 5;
            // 
            // lbl_ForgotPasswordEmailText
            // 
            this.lbl_ForgotPasswordEmailText.AutoSize = true;
            this.lbl_ForgotPasswordEmailText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordEmailText.Location = new System.Drawing.Point(213, 115);
            this.lbl_ForgotPasswordEmailText.Name = "lbl_ForgotPasswordEmailText";
            this.lbl_ForgotPasswordEmailText.Size = new System.Drawing.Size(736, 38);
            this.lbl_ForgotPasswordEmailText.TabIndex = 8;
            this.lbl_ForgotPasswordEmailText.Text = "Please enter the emailadress associated with your account";
            // 
            // lbl_ForgotPasswordCode
            // 
            this.lbl_ForgotPasswordCode.AutoSize = true;
            this.lbl_ForgotPasswordCode.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordCode.Location = new System.Drawing.Point(363, 260);
            this.lbl_ForgotPasswordCode.Name = "lbl_ForgotPasswordCode";
            this.lbl_ForgotPasswordCode.Size = new System.Drawing.Size(82, 32);
            this.lbl_ForgotPasswordCode.TabIndex = 3;
            this.lbl_ForgotPasswordCode.Text = "Code: ";
            // 
            // pnl_ForgotPasswordCode
            // 
            this.pnl_ForgotPasswordCode.Controls.Add(this.btn_ForgotPasswordCodeConfirm);
            this.pnl_ForgotPasswordCode.Controls.Add(this.tb_ForgotPasswordCode);
            this.pnl_ForgotPasswordCode.Controls.Add(this.lbl_ForgotPasswordCode);
            this.pnl_ForgotPasswordCode.Controls.Add(this.pic_LoginReturn2);
            this.pnl_ForgotPasswordCode.Location = new System.Drawing.Point(135, 88);
            this.pnl_ForgotPasswordCode.Name = "pnl_ForgotPasswordCode";
            this.pnl_ForgotPasswordCode.Size = new System.Drawing.Size(1140, 624);
            this.pnl_ForgotPasswordCode.TabIndex = 21;
            this.pnl_ForgotPasswordCode.Visible = false;
            // 
            // btn_ForgotPasswordCodeConfirm
            // 
            this.btn_ForgotPasswordCodeConfirm.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ForgotPasswordCodeConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ForgotPasswordCodeConfirm.Location = new System.Drawing.Point(529, 331);
            this.btn_ForgotPasswordCodeConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ForgotPasswordCodeConfirm.Name = "btn_ForgotPasswordCodeConfirm";
            this.btn_ForgotPasswordCodeConfirm.Size = new System.Drawing.Size(156, 65);
            this.btn_ForgotPasswordCodeConfirm.TabIndex = 5;
            this.btn_ForgotPasswordCodeConfirm.Text = "Confirm";
            this.btn_ForgotPasswordCodeConfirm.UseVisualStyleBackColor = false;
            // 
            // tb_ForgotPasswordCode
            // 
            this.tb_ForgotPasswordCode.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPasswordCode.Location = new System.Drawing.Point(506, 257);
            this.tb_ForgotPasswordCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ForgotPasswordCode.Name = "tb_ForgotPasswordCode";
            this.tb_ForgotPasswordCode.Size = new System.Drawing.Size(198, 39);
            this.tb_ForgotPasswordCode.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 908);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.pnl_ForgotPasswordNewPassword);
            this.Controls.Add(this.pnl_DashboardOptions);
            this.Controls.Add(this.pnl_ForgotPassword);
            this.Controls.Add(this.pnl_ForgotPasswordCode);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Ticket System";
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_ForgotPasswordNewPassword.ResumeLayout(false);
            this.pnl_ForgotPasswordNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoginReturn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoginReturn2)).EndInit();
            this.pnl_DashboardOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_homeButton)).EndInit();
            this.pnl_ForgotPassword.ResumeLayout(false);
            this.pnl_ForgotPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoginReturn)).EndInit();
            this.pnl_ForgotPasswordCode.ResumeLayout(false);
            this.pnl_ForgotPasswordCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Dashboard;
        private CircleProgressControl cpc_DashboardOvertimeTickets;
        private System.Windows.Forms.Label lbl_DashboardOvertimeText;
        private System.Windows.Forms.Label lbl_DashboardUnresolvedText;
        private CircleProgressControl cpc_DashboardUnresolvedTickets;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_ForgotPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_ForgotPasswordNewPassword;
        private System.Windows.Forms.PictureBox pic_LoginReturn3;
        private System.Windows.Forms.Button btn_ForgotPasswordConfirmNewPassword;
        private System.Windows.Forms.Label lbl_ForgotPasswordNewPassword2;
        private System.Windows.Forms.Label lbl_ForgotPasswordNewPassword1;
        private System.Windows.Forms.TextBox tb_ForgotPasswordConfirm;
        private System.Windows.Forms.TextBox tb_ForgotPasswordNew;
        private System.Windows.Forms.PictureBox pic_LoginReturn2;
        private System.Windows.Forms.Panel pnl_DashboardOptions;
        private System.Windows.Forms.Button btn_ManageUsers;
        private System.Windows.Forms.Button btn_Tickets;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox_homeButton;
        private System.Windows.Forms.Panel pnl_ForgotPassword;
        private System.Windows.Forms.PictureBox pic_LoginReturn;
        private System.Windows.Forms.Button btn_ForgotPasswordConfirm;
        private System.Windows.Forms.Label lbl_ForgotPasswordEmail;
        private System.Windows.Forms.TextBox tb_ForgotPassword;
        private System.Windows.Forms.Label lbl_ForgotPasswordEmailText;
        private System.Windows.Forms.Label lbl_ForgotPasswordCode;
        private System.Windows.Forms.Panel pnl_ForgotPasswordCode;
        private System.Windows.Forms.Button btn_ForgotPasswordCodeConfirm;
        private System.Windows.Forms.TextBox tb_ForgotPasswordCode;
    }
}

