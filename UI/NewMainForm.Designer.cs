
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
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.pnl_TicketOverview = new System.Windows.Forms.Panel();
            this.cbo_SortPriority = new System.Windows.Forms.ComboBox();
            this.btn_SortTicket = new System.Windows.Forms.Button();
            this.btn_DeleteTicket = new System.Windows.Forms.Button();
            this.btn_CreateTicketAdmin = new System.Windows.Forms.Button();
            this.cpc_DashboardOvertimeTickets = new UI.CircleProgressControl();
            this.lbl_DashboardOvertimeText = new System.Windows.Forms.Label();
            this.lbl_DashboardUnresolvedText = new System.Windows.Forms.Label();
            this.cpc_DashboardUnresolvedTickets = new UI.CircleProgressControl();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_ForgotPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_DashboardOptions = new System.Windows.Forms.Panel();
            this.btn_ManageUsers = new System.Windows.Forms.Button();
            this.btn_Tickets = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.pictureBox_homeButton = new System.Windows.Forms.PictureBox();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lv_TicketOverview = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.pnl_Login.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_TicketOverview.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_DashboardOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_homeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.pnl_Dashboard);
            this.pnl_Login.Controls.Add(this.btn_Login);
            this.pnl_Login.Controls.Add(this.tb_Username);
            this.pnl_Login.Controls.Add(this.lbl_Username);
            this.pnl_Login.Controls.Add(this.tb_Password);
            this.pnl_Login.Controls.Add(this.lbl_Password);
            this.pnl_Login.Controls.Add(this.lbl_ForgotPassword);
            this.pnl_Login.Controls.Add(this.panel2);
            this.pnl_Login.Location = new System.Drawing.Point(-1, 0);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1146, 730);
            this.pnl_Login.TabIndex = 10;
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.pnl_TicketOverview);
            this.pnl_Dashboard.Controls.Add(this.cpc_DashboardOvertimeTickets);
            this.pnl_Dashboard.Controls.Add(this.lbl_DashboardOvertimeText);
            this.pnl_Dashboard.Controls.Add(this.lbl_DashboardUnresolvedText);
            this.pnl_Dashboard.Controls.Add(this.cpc_DashboardUnresolvedTickets);
            this.pnl_Dashboard.Location = new System.Drawing.Point(12, 106);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1131, 621);
            this.pnl_Dashboard.TabIndex = 23;
            this.pnl_Dashboard.Visible = false;
            // 
            // pnl_TicketOverview
            // 
            this.pnl_TicketOverview.Controls.Add(this.cbo_SortPriority);
            this.pnl_TicketOverview.Controls.Add(this.btn_SortTicket);
            this.pnl_TicketOverview.Controls.Add(this.btn_DeleteTicket);
            this.pnl_TicketOverview.Controls.Add(this.btn_CreateTicketAdmin);
            this.pnl_TicketOverview.Controls.Add(this.lv_TicketOverview);
            this.pnl_TicketOverview.Location = new System.Drawing.Point(4, 4);
            this.pnl_TicketOverview.Name = "pnl_TicketOverview";
            this.pnl_TicketOverview.Size = new System.Drawing.Size(1124, 609);
            this.pnl_TicketOverview.TabIndex = 9;
            this.pnl_TicketOverview.Visible = false;
            // 
            // cbo_SortPriority
            // 
            this.cbo_SortPriority.DropDownHeight = 130;
            this.cbo_SortPriority.FormattingEnabled = true;
            this.cbo_SortPriority.IntegralHeight = false;
            this.cbo_SortPriority.Location = new System.Drawing.Point(67, 233);
            this.cbo_SortPriority.Margin = new System.Windows.Forms.Padding(3, 4, 4, 3);
            this.cbo_SortPriority.Name = "cbo_SortPriority";
            this.cbo_SortPriority.Size = new System.Drawing.Size(285, 28);
            this.cbo_SortPriority.TabIndex = 4;
            // 
            // btn_SortTicket
            // 
            this.btn_SortTicket.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SortTicket.Location = new System.Drawing.Point(63, 276);
            this.btn_SortTicket.Name = "btn_SortTicket";
            this.btn_SortTicket.Size = new System.Drawing.Size(290, 85);
            this.btn_SortTicket.TabIndex = 3;
            this.btn_SortTicket.Text = "Sort";
            this.btn_SortTicket.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteTicket
            // 
            this.btn_DeleteTicket.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DeleteTicket.Location = new System.Drawing.Point(67, 129);
            this.btn_DeleteTicket.Name = "btn_DeleteTicket";
            this.btn_DeleteTicket.Size = new System.Drawing.Size(286, 80);
            this.btn_DeleteTicket.TabIndex = 2;
            this.btn_DeleteTicket.Text = "Delete";
            this.btn_DeleteTicket.UseVisualStyleBackColor = true;
            this.btn_DeleteTicket.Click += new System.EventHandler(this.btn_DeleteTicket_Click);
            // 
            // btn_CreateTicketAdmin
            // 
            this.btn_CreateTicketAdmin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateTicketAdmin.Location = new System.Drawing.Point(67, 16);
            this.btn_CreateTicketAdmin.Name = "btn_CreateTicketAdmin";
            this.btn_CreateTicketAdmin.Size = new System.Drawing.Size(290, 86);
            this.btn_CreateTicketAdmin.TabIndex = 1;
            this.btn_CreateTicketAdmin.Text = "Create Ticket";
            this.btn_CreateTicketAdmin.UseVisualStyleBackColor = true;
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
            this.cpc_DashboardOvertimeTickets.Size = new System.Drawing.Size(282, 280);
            this.cpc_DashboardOvertimeTickets.TabIndex = 8;
            // 
            // lbl_DashboardOvertimeText
            // 
            this.lbl_DashboardOvertimeText.AutoSize = true;
            this.lbl_DashboardOvertimeText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DashboardOvertimeText.Location = new System.Drawing.Point(734, 84);
            this.lbl_DashboardOvertimeText.Name = "lbl_DashboardOvertimeText";
            this.lbl_DashboardOvertimeText.Size = new System.Drawing.Size(232, 38);
            this.lbl_DashboardOvertimeText.TabIndex = 7;
            this.lbl_DashboardOvertimeText.Text = "Overtime tickets: ";
            // 
            // lbl_DashboardUnresolvedText
            // 
            this.lbl_DashboardUnresolvedText.AutoSize = true;
            this.lbl_DashboardUnresolvedText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DashboardUnresolvedText.Location = new System.Drawing.Point(100, 75);
            this.lbl_DashboardUnresolvedText.Name = "lbl_DashboardUnresolvedText";
            this.lbl_DashboardUnresolvedText.Size = new System.Drawing.Size(257, 38);
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
            this.cpc_DashboardUnresolvedTickets.Size = new System.Drawing.Size(286, 280);
            this.cpc_DashboardUnresolvedTickets.TabIndex = 5;
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
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
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
            this.lbl_ForgotPassword.Click += new System.EventHandler(this.lbl_ForgotPassword_Click);
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
            // pnl_DashboardOptions
            // 
            this.pnl_DashboardOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnl_DashboardOptions.Controls.Add(this.btn_ManageUsers);
            this.pnl_DashboardOptions.Controls.Add(this.btn_Tickets);
            this.pnl_DashboardOptions.Controls.Add(this.btn_Dashboard);
            this.pnl_DashboardOptions.Controls.Add(this.pictureBox_homeButton);
            this.pnl_DashboardOptions.Location = new System.Drawing.Point(0, 0);
            this.pnl_DashboardOptions.Name = "pnl_DashboardOptions";
            this.pnl_DashboardOptions.Size = new System.Drawing.Size(1143, 100);
            this.pnl_DashboardOptions.TabIndex = 24;
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
            this.btn_ManageUsers.Click += new System.EventHandler(this.btn_ManageUsers_Click);
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
            this.btn_Tickets.Click += new System.EventHandler(this.btn_Tickets_Click);
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
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IncidentType";
            this.columnHeader2.Width = 100;
            // 
            // lv_TicketOverview
            // 
            this.lv_TicketOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_TicketOverview.FullRowSelect = true;
            this.lv_TicketOverview.GridLines = true;
            this.lv_TicketOverview.HideSelection = false;
            this.lv_TicketOverview.Location = new System.Drawing.Point(439, 16);
            this.lv_TicketOverview.Name = "lv_TicketOverview";
            this.lv_TicketOverview.Size = new System.Drawing.Size(677, 590);
            this.lv_TicketOverview.TabIndex = 0;
            this.lv_TicketOverview.UseCompatibleStateImageBehavior = false;
            this.lv_TicketOverview.View = System.Windows.Forms.View.Details;
            this.lv_TicketOverview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_TicketOverview_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Completed";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Deadline";
            this.columnHeader5.Width = 80;
            // 
            // NewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1144, 731);
            this.Controls.Add(this.pnl_DashboardOptions);
            this.Controls.Add(this.pnl_Login);
            this.Name = "NewMainForm";
            this.Text = "NewMainForm";
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.pnl_TicketOverview.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_DashboardOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_homeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel pnl_DashboardOptions;
        private System.Windows.Forms.Button btn_ManageUsers;
        private System.Windows.Forms.Button btn_Tickets;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox_homeButton;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private CircleProgressControl cpc_DashboardOvertimeTickets;
        private System.Windows.Forms.Label lbl_DashboardOvertimeText;
        private System.Windows.Forms.Label lbl_DashboardUnresolvedText;
        private CircleProgressControl cpc_DashboardUnresolvedTickets;
        private System.Windows.Forms.Panel pnl_TicketOverview;
        private System.Windows.Forms.ComboBox cbo_SortPriority;
        private System.Windows.Forms.Button btn_SortTicket;
        private System.Windows.Forms.Button btn_DeleteTicket;
        private System.Windows.Forms.Button btn_CreateTicketAdmin;
        private System.Windows.Forms.ListView lv_TicketOverview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}