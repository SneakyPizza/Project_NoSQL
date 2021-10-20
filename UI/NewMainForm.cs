using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace UI
{
    public partial class NewMainForm : Form
    {
        private Login_Logic _login_Logic = Login_Logic.Instance;
        private ForgotPassword_Logic _fp_logic = ForgotPassword_Logic.Instance;
        private Dashboard_Logic _dashboard_logic = Dashboard_Logic.Instance;
        private SortTicket_Logic _ticket_logic = SortTicket_Logic.Instance;
        private Ticket_Logic ticket_Logic = Ticket_Logic.Instance;
        private User _currentUser;
        private User_Logic _user = new User_Logic();
        private UserRole userRole;
        private string oldUserName;
        private string oldEmail;

        public NewMainForm()
        {
            InitializeComponent();
            LoadDubbleClickeventsListview();
        }

        #region Login - Yornie
        public void CheckUserAccess(User user)
        {
            switch (user.UserRole)
            {
                case UserRole.Admin:
                    btn_ManageUsers.Visible = true;
                    btn_Dashboard.Visible = true;
                    return;
                case UserRole.User:
                    btn_ManageUsers.Visible = false;
                    btn_Dashboard.Visible = false;
                    return;
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Password.Text) && !string.IsNullOrEmpty(tb_Username.Text))
            {
                _currentUser = _login_Logic.LoginUser(tb_Username.Text, tb_Password.Text);
                if (_currentUser != null)
                {
                    MessageBox.Show("Succes");
                    CheckUserAccess(_currentUser);
                    StartDashboard();
                    pnl_Dashboard.Refresh();

                    tb_Username.Clear();
                    tb_Password.Clear();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill in correct login details");
            }
        }
        private void lbl_ForgotPassword_Click(object sender, EventArgs e)
        {
            ResetPassword frm_ResetPassword = new ResetPassword();
            frm_ResetPassword.ShowDialog();
        }

        private void ReturnToLoginScreen()
        {
            pnl_Dashboard.Visible = false;
            _login_Logic.LogoutUser();
            pnl_Login.Visible = true;

            pnl_DashboardOptions.Visible = false;
        }

        #endregion

        #region Dashboard - Yornie
        private void StartDashboard()
        {
            pnl_Dashboard.Visible = true;
            pnl_DashboardOptions.Visible = true;
            int[] values = _dashboard_logic.GetDashboardValues();
            lbl_DashboardUnresolvedText.Text = String.Format("Unresolved Tickets: {0} / {1}", values[0], values[1]);
            lbl_DashboardOvertimeText.Text = String.Format("Overtime: {0} !", values[2]);

            //unresolved tickets circle
            cpc_DashboardUnresolvedTickets.CurrentValue = values[0];
            cpc_DashboardUnresolvedTickets.MaxValue = values[1];
            //Incidents past deadlines 
            cpc_DashboardOvertimeTickets.CurrentValue = values[2];
            cpc_DashboardOvertimeTickets.MaxValue = 20;
            cpc_DashboardOvertimeTickets.ProgressColor = Color.Red;
            pnl_Dashboard.Refresh();
        }

        private void btn_DashboardLogout_Click_1(object sender, EventArgs e)
        {
            ReturnToLoginScreen();
        }

        private void btn_ManageUsers_Click(object sender, EventArgs e)
        {
            pnl_TicketOverview.Visible = false;
            pnl_Usermanagement.Visible = true;
            refreshList();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            pnl_TicketOverview.Visible = false;
            pnl_Usermanagement.Visible = false;
            pnl_Dashboard.Visible = true;

            StartDashboard();
        }
        #endregion

        #region Tickets-Gilberto
        private void FillComboboxes()
        {
            cbo_UserReportedBy.DisplayMember = "Fullname";
            cbo_UserReportedBy.DataSource = _user.GetnormalandSuperUser().Item2;
            cbo_IncidentType.DataSource = Enum.GetValues(typeof(IncidentType));
            cbo_HandeledBy.DisplayMember = "Fullname";
            cbo_HandeledBy.DataSource = _user.GetnormalandSuperUser().Item1;
            cbo_TicketPriority.DataSource = Enum.GetValues(typeof(Priority));
            cbo_SortPriority.DataSource = Enum.GetValues(typeof(Priority));
        }
        private void btn_Tickets_Click(object sender, EventArgs e)
        {
            pnl_Usermanagement.Visible = false;
            // if user is normal user show other panels
            Loadlistview();
            FillComboboxes();
            switch (_currentUser.UserRole)
            {
                case UserRole.Admin:
                    pnl_TicketOverview.Visible = true;
                    return;
                case UserRole.User:
                    FormTicket frm_Ticket = new FormTicket(this, _currentUser);
                    frm_Ticket.ShowDialog();
                    return;
            }

        }

        public void FillListview(List<Ticket> tickets, ListView listviews)
        {
            listviews.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                ListViewItem lvTicket = new ListViewItem(ticket.Title);
                if (ticket.PastDeadline) { lvTicket.ForeColor = Color.Red; }
                lvTicket.Tag = ticket;
                lvTicket.SubItems.Add(ticket.IncidentType.ToString());
                lvTicket.SubItems.Add(ticket.Priority.ToString());
                lvTicket.SubItems.Add(ticket.Status.ToString());
                lvTicket.SubItems.Add(ticket.Deadline.ToString());
                lvTicket.SubItems.Add(ticket.IsCompleted);
                listviews.Items.AddRange(new ListViewItem[] { lvTicket });
                Console.ResetColor();
            }
        }
        private void Loadlistview()
        {
            FillListview(ticket_Logic.RetrieveAllTickets(), lv_TicketOverview);
        }
        private void LoadDubbleClickeventsListview()
        {
            lv_TicketOverview.MouseDoubleClick += new MouseEventHandler(lv_TicketOverview_MouseDoubleClick);
        }
        private void btn_SortPriority_Click(object sender, EventArgs e)
        {
            string sortPriority = cbo_SortPriority.Text;
            FillListview(ticket_Logic.OrderTickets(sortPriority), lv_TicketOverview);
        }
        private void lv_TicketOverview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lv_TicketOverview.SelectedItems.Count == 1)
            {
                Ticket ticket = (Ticket)lv_TicketOverview.SelectedItems[0].Tag;
                FormTicket frm_ticket = new FormTicket(ticket);
                frm_ticket.ShowDialog();
                Loadlistview();
            }
        }
        private void btn_DeleteTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = (Ticket)lv_TicketOverview.SelectedItems[0].Tag;
            DialogResult dialogResult = MessageBox.Show("The Ticket with the title " + ticket.Title + " will be deleted ", "Delete ticket", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ticket_Logic.DeleteTicket(ticket);
                MessageBox.Show("Ticket has been deleted");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Ticket has not been deleted");
            }


            Loadlistview();
        }

        private void btn_CreateTicketAdmin_Click(object sender, EventArgs e)
        {
            pnl_CreateTicketAdmin.Visible = true;
        }
        private void EmptyFieldsSubmitTicket()
        {
            txt_subjectIncident.Text = string.Empty;
            cbo_Deadline.Text = string.Empty;
            richtb_TicketDescription.Text = string.Empty;
        }
        private void btn_SubmitTicket_Click(object sender, EventArgs e)
        {
            User selectedUserID = (User)cbo_UserReportedBy.SelectedItem; // ticket for (Normal user)
            User selectedCreatedBy = (User)cbo_HandeledBy.SelectedItem; // ticket reportedby (Super User)
            Ticket ticket = new Ticket(selectedUserID.Id, selectedCreatedBy.Id,
                dtp_TicketCreationTImeAdmin.Value.AddDays(double.Parse(cbo_Deadline.Text.Where(char.IsDigit).ToArray())),
                dtp_TicketCreationTImeAdmin.Value, txt_subjectIncident.Text, richtb_TicketDescription.Text, string.Empty, (IncidentType)cbo_IncidentType.SelectedValue, (Priority)cbo_TicketPriority.SelectedValue, Status.Processing);
            if (ticket.Title == string.Empty || ticket.Description == string.Empty) { MessageBox.Show("No empty title or description allowed"); return; }
            ticket_Logic.InsertTicket(ticket);
            MessageBox.Show("ticket has been inserted");
            EmptyFieldsSubmitTicket();
        }

        private void btn_CancelTicket_Click(object sender, EventArgs e)
        {
            richtb_TicketDescription.Text = string.Empty;
            cbo_HandeledBy.Text = string.Empty;
            cbo_UserReportedBy.Text = string.Empty;
        }

        private void pic_BacktoTicketOverviewAdmin_Click(object sender, EventArgs e)
        {
            pnl_CreateTicketAdmin.Visible = false;
            Loadlistview();
        }
        #endregion

        private void btn_TickOv_Filter_Click(object sender, EventArgs e)
        {
            string keywords = txtb_TickOv_Filter.Text;
            FillListview(ticket_Logic.FilterList(keywords), lv_TicketOverview);
            MessageBox.Show("The list has been filtered");
        }

        private void btn_UsMan_AddUser_Click(object sender, EventArgs e)
        {
            UserRole userRole;
            string Firstname = txtb_UsMan_firstname.Text;
            string Lastname = txtb_UsMan_lastname.Text;
            string Username = txtb_UsMan_username.Text;
            string Password = txtb_UsMan_password.Text;
            string Email = txtb_UsMan_email.Text;
            string[] SC = { Firstname, Lastname, Username, Password, Email };
            char CheckEmail = '@';
            foreach (string item in SC)
            {
                if (item == "")
                {
                    MessageBox.Show("Text box is not filled in!");
                    return;
                }
            }
            if (!Email.Contains(CheckEmail))
            {
                Email = Email + "@hotmail.com";
            }
            if (rb_UsMan_admin.Checked)
            {
                userRole = UserRole.Admin;
            }
            else
            {
            userRole = UserRole.User;
            }
            if (_user.UserCheck(Username))
            {
                MessageBox.Show("Username is already taken!");
                return;
            }
            if (_user.EmailCheck(Email))
            {
                MessageBox.Show("Email is already taken!");
            }
            else
            {
                _user.InsertUser(Username, Password, Firstname, Lastname, userRole, Email);
            }
             refreshList();
        }
        private void refreshList()
        {
            lv_UsMan_ListViewUsermanagement.Clear();
            FullListViewUsermanagement();
            lv_UsMan_ListViewUsermanagement.SelectedItems.Clear();
            this.EmptyUsManTextbBox();
        }
        private void FullListViewUsermanagement()
        {
            lv_UsMan_ListViewUsermanagement.Columns.Add("Username", 100);
            lv_UsMan_ListViewUsermanagement.Columns.Add("Password", 100);
            lv_UsMan_ListViewUsermanagement.Columns.Add("Firstname", 100);
            lv_UsMan_ListViewUsermanagement.Columns.Add("Lastname", 100);
            lv_UsMan_ListViewUsermanagement.Columns.Add("User Role", 100);
            lv_UsMan_ListViewUsermanagement.Columns.Add("Email", 100);
            foreach (User user in _user.GetnewUser())
            {
                ListViewItem UsManlistview = new ListViewItem(user.Username);
                UsManlistview.SubItems.Add(user.Password);
                UsManlistview.SubItems.Add(user.Firstname);
                UsManlistview.SubItems.Add(user.Lastname);
                UsManlistview.SubItems.Add(user.UserRole.ToString());
                UsManlistview.SubItems.Add(user.Email);
                lv_UsMan_ListViewUsermanagement.Items.AddRange(new ListViewItem[] { UsManlistview });
            }
        }

        private void lv_UsMan_ListViewUsermanagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lv_UsMan_ListViewUsermanagement.SelectedItems.Count == 0)
                return;

            EmptyUsManTextbBox();
            string username, password, firstname, lastname, email;

            this.oldUserName = this.lv_UsMan_ListViewUsermanagement.SelectedItems[0].SubItems[0].Text;
            username = this.lv_UsMan_ListViewUsermanagement.SelectedItems[0].SubItems[0].Text;
            password = this.lv_UsMan_ListViewUsermanagement.SelectedItems[0].SubItems[1].Text;
            firstname = this.lv_UsMan_ListViewUsermanagement.SelectedItems[0].SubItems[2].Text;
            lastname = this.lv_UsMan_ListViewUsermanagement.SelectedItems[0].SubItems[3].Text;
            this.userRole = (UserRole)Enum.Parse(typeof(UserRole), this.lv_UsMan_ListViewUsermanagement.SelectedItems[0].SubItems[4].Text);
            this.oldEmail = this.lv_UsMan_ListViewUsermanagement.SelectedItems[0].SubItems[5].Text;
            email = this.lv_UsMan_ListViewUsermanagement.SelectedItems[0].SubItems[5].Text;

            txtb_UsMan_username.Text = username;
            txtb_UsMan_password.Text = password;
            txtb_UsMan_firstname.Text = firstname;
            txtb_UsMan_lastname.Text = lastname;
            if (this.userRole == UserRole.Admin)
            {
                rb_UsMan_admin.Checked = true;
            }
            else
            {
                rb_UsMan_user.Checked = true;
            }
            txtb_UsMan_email.Text = email;
        }
        private void EmptyUsManTextbBox()
        {
            txtb_UsMan_username.Text = string.Empty;
            txtb_UsMan_password.Text = string.Empty;
            txtb_UsMan_firstname.Text = string.Empty;
            txtb_UsMan_lastname.Text = string.Empty;
            txtb_UsMan_email.Text = string.Empty;
        }

        private void btn_UsMan_Update_Click(object sender, EventArgs e)
        {
            string username = txtb_UsMan_username.Text;
            string password = txtb_UsMan_password.Text;
            string firstname = txtb_UsMan_firstname.Text;
            string lastname = txtb_UsMan_lastname.Text;
            string email = txtb_UsMan_email.Text;
            if (rb_UsMan_admin.Checked)
            {
                userRole = UserRole.Admin;
            }
            else
            {
                userRole = UserRole.User;
            }
            if (this.oldUserName != username)
            {
                if (_user.UserCheck(username))
                {
                    MessageBox.Show("Username is already taken!");
                    return;
                }
            }
            if (this.oldEmail != email)
            {
                if (_user.EmailCheck(email))
                {
                    MessageBox.Show("Email is already taken!");
                }
            }
            else
            {
                _user.UpdateUser(this.oldUserName, firstname, lastname, username, password, this.userRole, email);
            }

            this.oldEmail = email;
            this.oldUserName = username;
            refreshList();
        }

        private void btn_UsMan_Delete_Click(object sender, EventArgs e)
        {
            if (this.oldUserName == null)
            {
                return;
            }
            _user.DeleteUser(this.oldUserName);
            this.oldUserName = null;
            refreshList();
        }
    }
}
