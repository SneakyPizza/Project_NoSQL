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
        private Ticket_Logic ticket_Logic = Ticket_Logic.Instance;
        private User _currentUser;
        User_Logic _user;

        public NewMainForm()
        {
            InitializeComponent();
            _user = new User_Logic();
            LoadDubbleClickeventsListview();
        }

        #region Login - Yornie
        public void CheckUserAccess(User user) {
            switch (user.UserRole)
            {
                case UserRole.Admin:
                    btn_ManageUsers.Visible = true;
                    btn_Dashboard.Visible = true;
                    return;
                case UserRole.User:
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

        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            pnl_TicketOverview.Visible = false;
            pnl_Dashboard.Visible = true;
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
            if (lv_TicketOverview.SelectedItems.Count == 1) {
                Ticket ticket = (Ticket)lv_TicketOverview.SelectedItems[0].Tag;
                FormTicket frm_ticket = new FormTicket(ticket);
                    frm_ticket.ShowDialog();
                Loadlistview();
            }
        }
        private void btn_DeleteTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = (Ticket)lv_TicketOverview.SelectedItems[0].Tag;
            ticket_Logic.DeleteTicket(ticket);
            MessageBox.Show("Ticket has been deleted");
            Loadlistview();
        }

        private void btn_CreateTicketAdmin_Click(object sender, EventArgs e)
        {
            pnl_CreateTicketAdmin.Visible = true;
        }

        private void btn_SubmitTicket_Click(object sender, EventArgs e)
        {
            User selectedUserID = (User)cbo_UserReportedBy.SelectedItem; // ticket for (Normal user)
            User selectedCreatedBy = (User)cbo_HandeledBy.SelectedItem; // ticket reportedby (Super User)
            Ticket ticket = new Ticket(selectedUserID.Id, selectedCreatedBy.Id,
                dtp_TicketCreationTImeAdmin.Value.AddDays(double.Parse(cbo_Deadline.Text.Where(char.IsDigit).ToArray())),
                dtp_TicketCreationTImeAdmin.Value, txt_subjectIncident.Text, richtb_TicketDescription.Text, string.Empty, (IncidentType)cbo_IncidentType.SelectedValue, (Priority)cbo_TicketPriority.SelectedValue, Status.Processing);
            ticket_Logic.InsertTicket(ticket);
            MessageBox.Show("ticket has been inserted");
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
    }
}
