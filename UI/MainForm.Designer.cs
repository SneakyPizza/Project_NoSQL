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
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_ForgotPassword = new System.Windows.Forms.Label();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.pnl_ForgotPassword = new System.Windows.Forms.Panel();
            this.pnl_ForgotPasswordCode = new System.Windows.Forms.Panel();
            this.pnl_ForgotPasswordNewPassword = new System.Windows.Forms.Panel();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_DashboardCurrentUserLastname = new System.Windows.Forms.Label();
            this.lbl_DashboardCurrentFirstname = new System.Windows.Forms.Label();
            this.btn_DashboardOpenUsers = new System.Windows.Forms.Button();
            this.btn_DashboardLogout = new System.Windows.Forms.Button();
            this.cpc_DashboardOvertimeTickets = new UI.CircleProgressControl();
            this.lbl_DashboardOvertimeText = new System.Windows.Forms.Label();
            this.lbl_DashboardUnresolvedText = new System.Windows.Forms.Label();
            this.cpc_DashboardUnresolvedTickets = new UI.CircleProgressControl();
            this.btn_DashboardOpenTickets = new System.Windows.Forms.Button();
            this.btn_LoginReturn3 = new System.Windows.Forms.Button();
            this.btn_ForgotPasswordConfirmNewPassword = new System.Windows.Forms.Button();
            this.lbl_ForgotPasswordNewPassword2 = new System.Windows.Forms.Label();
            this.lbl_ForgotPasswordNewPassword1 = new System.Windows.Forms.Label();
            this.tb_ForgotPasswordConfirm = new System.Windows.Forms.TextBox();
            this.tb_ForgotPasswordNew = new System.Windows.Forms.TextBox();
            this.btn_ForgotPasswordCodeConfirm = new System.Windows.Forms.Button();
            this.tb_ForgotPasswordCode = new System.Windows.Forms.TextBox();
            this.lbl_ForgotPasswordCode = new System.Windows.Forms.Label();
            this.btn_LoginReturn2 = new System.Windows.Forms.Button();
            this.btn_ForgotPasswordConfirm = new System.Windows.Forms.Button();
            this.lbl_ForgotPasswordEmail = new System.Windows.Forms.Label();
            this.tb_ForgotPassword = new System.Windows.Forms.TextBox();
            this.lbl_ForgotPasswordEmailText = new System.Windows.Forms.Label();
            this.btn_LoginReturn1 = new System.Windows.Forms.Button();
            this.pnl_Login.SuspendLayout();
            this.pnl_ForgotPassword.SuspendLayout();
            this.pnl_ForgotPasswordCode.SuspendLayout();
            this.pnl_ForgotPasswordNewPassword.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Password.Location = new System.Drawing.Point(618, 373);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(235, 39);
            this.tb_Password.TabIndex = 0;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Username.Location = new System.Drawing.Point(618, 291);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(235, 39);
            this.tb_Username.TabIndex = 1;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Username.Location = new System.Drawing.Point(446, 300);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(126, 32);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Password.Location = new System.Drawing.Point(446, 383);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(116, 32);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password:";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(0, 0);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 8;
            // 
            // lbl_ForgotPassword
            // 
            this.lbl_ForgotPassword.Location = new System.Drawing.Point(0, 0);
            this.lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            this.lbl_ForgotPassword.Size = new System.Drawing.Size(100, 23);
            this.lbl_ForgotPassword.TabIndex = 7;
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.pnl_ForgotPassword);
            this.pnl_Login.Controls.Add(this.lbl_ForgotPassword);
            this.pnl_Login.Controls.Add(this.lbl_Username);
            this.pnl_Login.Controls.Add(this.tb_Password);
            this.pnl_Login.Controls.Add(this.btn_Login);
            this.pnl_Login.Controls.Add(this.lbl_Password);
            this.pnl_Login.Controls.Add(this.tb_Username);
            this.pnl_Login.Location = new System.Drawing.Point(0, 59);
            this.pnl_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1446, 851);
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
            this.pnl_ForgotPassword.Location = new System.Drawing.Point(3, 4);
            this.pnl_ForgotPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_ForgotPassword.Name = "pnl_ForgotPassword";
            this.pnl_ForgotPassword.Size = new System.Drawing.Size(1417, 820);
            this.pnl_ForgotPassword.TabIndex = 6;
            // 
            // pnl_ForgotPasswordCode
            // 
            this.pnl_ForgotPasswordCode.Controls.Add(this.pnl_ForgotPasswordNewPassword);
            this.pnl_ForgotPasswordCode.Controls.Add(this.btn_ForgotPasswordCodeConfirm);
            this.pnl_ForgotPasswordCode.Controls.Add(this.tb_ForgotPasswordCode);
            this.pnl_ForgotPasswordCode.Controls.Add(this.lbl_ForgotPasswordCode);
            this.pnl_ForgotPasswordCode.Controls.Add(this.btn_LoginReturn2);
            this.pnl_ForgotPasswordCode.Location = new System.Drawing.Point(9, 4);
            this.pnl_ForgotPasswordCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_ForgotPasswordCode.Name = "pnl_ForgotPasswordCode";
            this.pnl_ForgotPasswordCode.Size = new System.Drawing.Size(1395, 700);
            this.pnl_ForgotPasswordCode.TabIndex = 3;
            // 
            // pnl_ForgotPasswordNewPassword
            // 
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.pnl_Dashboard);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.btn_LoginReturn3);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.btn_ForgotPasswordConfirmNewPassword);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.lbl_ForgotPasswordNewPassword2);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.lbl_ForgotPasswordNewPassword1);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.tb_ForgotPasswordConfirm);
            this.pnl_ForgotPasswordNewPassword.Controls.Add(this.tb_ForgotPasswordNew);
            this.pnl_ForgotPasswordNewPassword.Location = new System.Drawing.Point(340, 433);
            this.pnl_ForgotPasswordNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_ForgotPasswordNewPassword.Name = "pnl_ForgotPasswordNewPassword";
            this.pnl_ForgotPasswordNewPassword.Size = new System.Drawing.Size(1389, 692);
            this.pnl_ForgotPasswordNewPassword.TabIndex = 3;
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_DashboardCurrentUserLastname);
            this.pnl_Dashboard.Controls.Add(this.lbl_DashboardCurrentFirstname);
            this.pnl_Dashboard.Controls.Add(this.btn_DashboardOpenUsers);
            this.pnl_Dashboard.Controls.Add(this.btn_DashboardLogout);
            this.pnl_Dashboard.Controls.Add(this.cpc_DashboardOvertimeTickets);
            this.pnl_Dashboard.Controls.Add(this.lbl_DashboardOvertimeText);
            this.pnl_Dashboard.Controls.Add(this.lbl_DashboardUnresolvedText);
            this.pnl_Dashboard.Controls.Add(this.cpc_DashboardUnresolvedTickets);
            this.pnl_Dashboard.Controls.Add(this.btn_DashboardOpenTickets);
            this.pnl_Dashboard.Location = new System.Drawing.Point(198, 248);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1442, 863);
            this.pnl_Dashboard.TabIndex = 7;
            // 
            // lbl_DashboardCurrentUserLastname
            // 
            this.lbl_DashboardCurrentUserLastname.AutoSize = true;
            this.lbl_DashboardCurrentUserLastname.Location = new System.Drawing.Point(1361, 72);
            this.lbl_DashboardCurrentUserLastname.Name = "lbl_DashboardCurrentUserLastname";
            this.lbl_DashboardCurrentUserLastname.Size = new System.Drawing.Size(15, 20);
            this.lbl_DashboardCurrentUserLastname.TabIndex = 8;
            this.lbl_DashboardCurrentUserLastname.Text = "..";
            // 
            // lbl_DashboardCurrentFirstname
            // 
            this.lbl_DashboardCurrentFirstname.AutoSize = true;
            this.lbl_DashboardCurrentFirstname.Location = new System.Drawing.Point(1291, 71);
            this.lbl_DashboardCurrentFirstname.Name = "lbl_DashboardCurrentFirstname";
            this.lbl_DashboardCurrentFirstname.Size = new System.Drawing.Size(12, 20);
            this.lbl_DashboardCurrentFirstname.TabIndex = 7;
            this.lbl_DashboardCurrentFirstname.Text = ".";
            // 
            // btn_DashboardOpenUsers
            // 
            this.btn_DashboardOpenUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DashboardOpenUsers.Location = new System.Drawing.Point(834, 79);
            this.btn_DashboardOpenUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DashboardOpenUsers.Name = "btn_DashboardOpenUsers";
            this.btn_DashboardOpenUsers.Size = new System.Drawing.Size(240, 132);
            this.btn_DashboardOpenUsers.TabIndex = 6;
            this.btn_DashboardOpenUsers.Text = "Open Users";
            this.btn_DashboardOpenUsers.UseVisualStyleBackColor = true;
            // 
            // btn_DashboardLogout
            // 
            this.btn_DashboardLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DashboardLogout.Location = new System.Drawing.Point(1328, 4);
            this.btn_DashboardLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DashboardLogout.Name = "btn_DashboardLogout";
            this.btn_DashboardLogout.Size = new System.Drawing.Size(111, 49);
            this.btn_DashboardLogout.TabIndex = 5;
            this.btn_DashboardLogout.Text = "Logout";
            this.btn_DashboardLogout.UseVisualStyleBackColor = true;
            // 
            // cpc_DashboardOvertimeTickets
            // 
            this.cpc_DashboardOvertimeTickets.CurrentValue = 50D;
            this.cpc_DashboardOvertimeTickets.FillColor = System.Drawing.Color.White;
            this.cpc_DashboardOvertimeTickets.Location = new System.Drawing.Point(834, 349);
            this.cpc_DashboardOvertimeTickets.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cpc_DashboardOvertimeTickets.MaxValue = 100D;
            this.cpc_DashboardOvertimeTickets.Name = "cpc_DashboardOvertimeTickets";
            this.cpc_DashboardOvertimeTickets.ProgressColor = System.Drawing.Color.Orange;
            this.cpc_DashboardOvertimeTickets.Size = new System.Drawing.Size(240, 280);
            this.cpc_DashboardOvertimeTickets.TabIndex = 4;
            // 
            // lbl_DashboardOvertimeText
            // 
            this.lbl_DashboardOvertimeText.AutoSize = true;
            this.lbl_DashboardOvertimeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DashboardOvertimeText.Location = new System.Drawing.Point(784, 299);
            this.lbl_DashboardOvertimeText.Name = "lbl_DashboardOvertimeText";
            this.lbl_DashboardOvertimeText.Size = new System.Drawing.Size(163, 28);
            this.lbl_DashboardOvertimeText.TabIndex = 3;
            this.lbl_DashboardOvertimeText.Text = "Overtime tickets: ";
            // 
            // lbl_DashboardUnresolvedText
            // 
            this.lbl_DashboardUnresolvedText.AutoSize = true;
            this.lbl_DashboardUnresolvedText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DashboardUnresolvedText.Location = new System.Drawing.Point(123, 291);
            this.lbl_DashboardUnresolvedText.Name = "lbl_DashboardUnresolvedText";
            this.lbl_DashboardUnresolvedText.Size = new System.Drawing.Size(181, 28);
            this.lbl_DashboardUnresolvedText.TabIndex = 2;
            this.lbl_DashboardUnresolvedText.Text = "Unresolved tickets: ";
            // 
            // cpc_DashboardUnresolvedTickets
            // 
            this.cpc_DashboardUnresolvedTickets.CurrentValue = 50D;
            this.cpc_DashboardUnresolvedTickets.FillColor = System.Drawing.Color.White;
            this.cpc_DashboardUnresolvedTickets.Location = new System.Drawing.Point(182, 327);
            this.cpc_DashboardUnresolvedTickets.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cpc_DashboardUnresolvedTickets.MaxValue = 100D;
            this.cpc_DashboardUnresolvedTickets.Name = "cpc_DashboardUnresolvedTickets";
            this.cpc_DashboardUnresolvedTickets.ProgressColor = System.Drawing.Color.Orange;
            this.cpc_DashboardUnresolvedTickets.Size = new System.Drawing.Size(240, 280);
            this.cpc_DashboardUnresolvedTickets.TabIndex = 1;
            // 
            // btn_DashboardOpenTickets
            // 
            this.btn_DashboardOpenTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DashboardOpenTickets.Location = new System.Drawing.Point(182, 79);
            this.btn_DashboardOpenTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DashboardOpenTickets.Name = "btn_DashboardOpenTickets";
            this.btn_DashboardOpenTickets.Size = new System.Drawing.Size(240, 132);
            this.btn_DashboardOpenTickets.TabIndex = 0;
            this.btn_DashboardOpenTickets.Text = "Open Tickets";
            this.btn_DashboardOpenTickets.UseVisualStyleBackColor = true;
            // 
            // btn_LoginReturn3
            // 
            this.btn_LoginReturn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginReturn3.Location = new System.Drawing.Point(8, 24);
            this.btn_LoginReturn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LoginReturn3.Name = "btn_LoginReturn3";
            this.btn_LoginReturn3.Size = new System.Drawing.Size(157, 51);
            this.btn_LoginReturn3.TabIndex = 6;
            this.btn_LoginReturn3.Text = "Return";
            this.btn_LoginReturn3.UseVisualStyleBackColor = true;
            // 
            // btn_ForgotPasswordConfirmNewPassword
            // 
            this.btn_ForgotPasswordConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ForgotPasswordConfirmNewPassword.Location = new System.Drawing.Point(551, 321);
            this.btn_ForgotPasswordConfirmNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ForgotPasswordConfirmNewPassword.Name = "btn_ForgotPasswordConfirmNewPassword";
            this.btn_ForgotPasswordConfirmNewPassword.Size = new System.Drawing.Size(157, 51);
            this.btn_ForgotPasswordConfirmNewPassword.TabIndex = 4;
            this.btn_ForgotPasswordConfirmNewPassword.Text = "Confirm";
            this.btn_ForgotPasswordConfirmNewPassword.UseVisualStyleBackColor = true;
            // 
            // lbl_ForgotPasswordNewPassword2
            // 
            this.lbl_ForgotPasswordNewPassword2.AutoSize = true;
            this.lbl_ForgotPasswordNewPassword2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordNewPassword2.Location = new System.Drawing.Point(342, 256);
            this.lbl_ForgotPasswordNewPassword2.Name = "lbl_ForgotPasswordNewPassword2";
            this.lbl_ForgotPasswordNewPassword2.Size = new System.Drawing.Size(174, 28);
            this.lbl_ForgotPasswordNewPassword2.TabIndex = 3;
            this.lbl_ForgotPasswordNewPassword2.Text = "Confirm password:";
            // 
            // lbl_ForgotPasswordNewPassword1
            // 
            this.lbl_ForgotPasswordNewPassword1.AutoSize = true;
            this.lbl_ForgotPasswordNewPassword1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordNewPassword1.Location = new System.Drawing.Point(367, 187);
            this.lbl_ForgotPasswordNewPassword1.Name = "lbl_ForgotPasswordNewPassword1";
            this.lbl_ForgotPasswordNewPassword1.Size = new System.Drawing.Size(143, 28);
            this.lbl_ForgotPasswordNewPassword1.TabIndex = 2;
            this.lbl_ForgotPasswordNewPassword1.Text = "New password:";
            // 
            // tb_ForgotPasswordConfirm
            // 
            this.tb_ForgotPasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPasswordConfirm.Location = new System.Drawing.Point(528, 248);
            this.tb_ForgotPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ForgotPasswordConfirm.Name = "tb_ForgotPasswordConfirm";
            this.tb_ForgotPasswordConfirm.PasswordChar = '*';
            this.tb_ForgotPasswordConfirm.Size = new System.Drawing.Size(198, 34);
            this.tb_ForgotPasswordConfirm.TabIndex = 1;
            // 
            // tb_ForgotPasswordNew
            // 
            this.tb_ForgotPasswordNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPasswordNew.Location = new System.Drawing.Point(528, 176);
            this.tb_ForgotPasswordNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ForgotPasswordNew.Name = "tb_ForgotPasswordNew";
            this.tb_ForgotPasswordNew.PasswordChar = '*';
            this.tb_ForgotPasswordNew.Size = new System.Drawing.Size(198, 34);
            this.tb_ForgotPasswordNew.TabIndex = 0;
            // 
            // btn_ForgotPasswordCodeConfirm
            // 
            this.btn_ForgotPasswordCodeConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ForgotPasswordCodeConfirm.Location = new System.Drawing.Point(554, 349);
            this.btn_ForgotPasswordCodeConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ForgotPasswordCodeConfirm.Name = "btn_ForgotPasswordCodeConfirm";
            this.btn_ForgotPasswordCodeConfirm.Size = new System.Drawing.Size(157, 51);
            this.btn_ForgotPasswordCodeConfirm.TabIndex = 2;
            this.btn_ForgotPasswordCodeConfirm.Text = "Confirm";
            this.btn_ForgotPasswordCodeConfirm.UseVisualStyleBackColor = true;
            // 
            // tb_ForgotPasswordCode
            // 
            this.tb_ForgotPasswordCode.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPasswordCode.Location = new System.Drawing.Point(531, 299);
            this.tb_ForgotPasswordCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ForgotPasswordCode.Name = "tb_ForgotPasswordCode";
            this.tb_ForgotPasswordCode.Size = new System.Drawing.Size(198, 39);
            this.tb_ForgotPasswordCode.TabIndex = 1;
            // 
            // lbl_ForgotPasswordCode
            // 
            this.lbl_ForgotPasswordCode.AutoSize = true;
            this.lbl_ForgotPasswordCode.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordCode.Location = new System.Drawing.Point(429, 303);
            this.lbl_ForgotPasswordCode.Name = "lbl_ForgotPasswordCode";
            this.lbl_ForgotPasswordCode.Size = new System.Drawing.Size(82, 32);
            this.lbl_ForgotPasswordCode.TabIndex = 0;
            this.lbl_ForgotPasswordCode.Text = "Code: ";
            // 
            // btn_LoginReturn2
            // 
            this.btn_LoginReturn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginReturn2.Location = new System.Drawing.Point(19, 19);
            this.btn_LoginReturn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LoginReturn2.Name = "btn_LoginReturn2";
            this.btn_LoginReturn2.Size = new System.Drawing.Size(157, 51);
            this.btn_LoginReturn2.TabIndex = 5;
            this.btn_LoginReturn2.Text = "Return";
            this.btn_LoginReturn2.UseVisualStyleBackColor = true;
            // 
            // btn_ForgotPasswordConfirm
            // 
            this.btn_ForgotPasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ForgotPasswordConfirm.Location = new System.Drawing.Point(433, 224);
            this.btn_ForgotPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ForgotPasswordConfirm.Name = "btn_ForgotPasswordConfirm";
            this.btn_ForgotPasswordConfirm.Size = new System.Drawing.Size(157, 51);
            this.btn_ForgotPasswordConfirm.TabIndex = 2;
            this.btn_ForgotPasswordConfirm.Text = "Confirm";
            this.btn_ForgotPasswordConfirm.UseVisualStyleBackColor = true;
            // 
            // lbl_ForgotPasswordEmail
            // 
            this.lbl_ForgotPasswordEmail.AutoSize = true;
            this.lbl_ForgotPasswordEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgotPasswordEmail.Location = new System.Drawing.Point(265, 177);
            this.lbl_ForgotPasswordEmail.Name = "lbl_ForgotPasswordEmail";
            this.lbl_ForgotPasswordEmail.Size = new System.Drawing.Size(83, 32);
            this.lbl_ForgotPasswordEmail.TabIndex = 1;
            this.lbl_ForgotPasswordEmail.Text = "Email: ";
            // 
            // tb_ForgotPassword
            // 
            this.tb_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ForgotPassword.Location = new System.Drawing.Point(349, 173);
            this.tb_ForgotPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ForgotPassword.Name = "tb_ForgotPassword";
            this.tb_ForgotPassword.Size = new System.Drawing.Size(345, 39);
            this.tb_ForgotPassword.TabIndex = 0;
            // 
            // lbl_ForgotPasswordEmailText
            // 
            this.lbl_ForgotPasswordEmailText.AutoSize = true;
            this.lbl_ForgotPasswordEmailText.Location = new System.Drawing.Point(349, 135);
            this.lbl_ForgotPasswordEmailText.Name = "lbl_ForgotPasswordEmailText";
            this.lbl_ForgotPasswordEmailText.Size = new System.Drawing.Size(392, 20);
            this.lbl_ForgotPasswordEmailText.TabIndex = 4;
            this.lbl_ForgotPasswordEmailText.Text = "Please enter the emailadress associated with your account";
            // 
            // btn_LoginReturn1
            // 
            this.btn_LoginReturn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginReturn1.Location = new System.Drawing.Point(34, 37);
            this.btn_LoginReturn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LoginReturn1.Name = "btn_LoginReturn1";
            this.btn_LoginReturn1.Size = new System.Drawing.Size(157, 51);
            this.btn_LoginReturn1.TabIndex = 4;
            this.btn_LoginReturn1.Text = "Return";
            this.btn_LoginReturn1.UseVisualStyleBackColor = true;
            this.btn_LoginReturn1.Click += new System.EventHandler(this.btn_LoginReturn1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 908);
            this.Controls.Add(this.pnl_Login);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
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
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_DashboardUnresolvedText;
        private CircleProgressControl cpc_DashboardUnresolvedTickets;
        private System.Windows.Forms.Button btn_DashboardOpenTickets;
        private System.Windows.Forms.Button btn_DashboardLogout;
        private CircleProgressControl cpc_DashboardOvertimeTickets;
        private System.Windows.Forms.Label lbl_DashboardOvertimeText;
        private System.Windows.Forms.Button btn_DashboardOpenUsers;
        private System.Windows.Forms.Label lbl_DashboardCurrentFirstname;
        private System.Windows.Forms.Label lbl_DashboardCurrentUserLastname;
    }
}

