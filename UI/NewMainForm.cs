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
        User_Logic _user;
        private User _currentUser;
        private string _emailReset;

        public NewMainForm()
        {
            InitializeComponent();
            _user = new User_Logic();
            LoadDubbleClickeventsListview();
            //pnl_Dashboard.Visible = false;
        }
        private void HideAllPanels()
        {
            // pnl_DashboardOptions.Visible = false;
            //pnl_ForgotPassword.Visible = false;

            //pnl_ForgotPasswordCode.Visible = false;
            //pnl_ForgotPasswordNewPassword.Visible = false;
            //pnl_Dashboard.Visible = false;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Password.Text) && !string.IsNullOrEmpty(tb_Username.Text))
            {
                if (_login_Logic.LoginUser(tb_Username.Text, tb_Password.Text))
                {


                    // HideAllPanels();

                    MessageBox.Show("Succes");
                    // HideAllPanels();
                    pnl_Dashboard.Visible = true;
                    pnl_DashboardOptions.Visible = true;
                    //   StartDashboard();
                    pnl_Dashboard.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill in login details");
            }
        }
        private void lbl_ForgotPassword_Click(object sender, EventArgs e)
        {
            // pnl_ForgotPassword.Visible = true;
            ResetPassword frm_ResetPassword = new ResetPassword();
            frm_ResetPassword.ShowDialog();
        }

        //private void btn_ForgotPasswordConfirm_Click(object sender, EventArgs e)
        //{
        //    string input = tb_ForgotPassword.Text.Trim();
        //    if (!string.IsNullOrEmpty(input) && _fp_logic.ValidEmailAdress(input))
        //    {
        //        _emailReset = input;
        //        _fp_logic.SendMail(_emailReset);
        //      //  HideAllPanels();
        //        pnl_ForgotPasswordCode.Visible = true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid Email");
        //    }
        //}

        //private void btn_ForgotPasswordCodeConfirm_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(tb_ForgotPasswordCode.Text))
        //    {
        //        if (_fp_logic.ResetCodeCheck(tb_ForgotPasswordCode.Text))
        //        {
        //            MessageBox.Show("Correct code");
        //            pnl_ForgotPasswordNewPassword.Visible = true;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Incorrect code");
        //        }
        //    }
        //}

        private void btn_ForgotPasswordConfirmNewPassword_Click(object sender, EventArgs e)
        {
            //if ((!string.IsNullOrEmpty(tb_ForgotPasswordNew.Text) || !string.IsNullOrEmpty(tb_ForgotPasswordConfirm.Text)) && tb_ForgotPasswordConfirm.Text.Trim() == tb_ForgotPasswordNew.Text.Trim())
            //{
            //    _fp_logic.UpdateUserPassword(_emailReset, tb_ForgotPasswordConfirm.Text.Trim());
            //    MessageBox.Show("Your password has succesfully been changed!");
            //    ReturnToLogin();
            //}
            //else
            //{

            //    MessageBox.Show("Invalid password");
            //    tb_ForgotPasswordNew.Clear();
            //    tb_ForgotPasswordConfirm.Clear();
            //}
        }
        //private void ReturnToLogin()
        //{
        //    pnl_ForgotPassword.Visible = false;
        //    pnl_ForgotPasswordCode.Visible = false;
        //    pnl_ForgotPasswordNewPassword.Visible = false;
        //   // pnl_Login.Visible = true;
        //    _fp_logic.RemoveResetCode();
        //    if (_emailReset != null) { _emailReset = null; }
        //}
        //private void ReturnToLoginEvent(object sender, EventArgs e)
        //{
        //    ReturnToLogin();
        //}
        //#endregion

        #region Dashboard
        private void StartDashboard()
        {
            pnl_Dashboard.Visible = true;
            //  pnl_Dashboard.BringToFront();
            pnl_DashboardOptions.Visible = true;
            //    Getting userdata
            //       string Username = logic.GetLoggedUsername();
            //  string userrole = logic.GetLoggedUserRole().ToString();

            //    lbl_DashboardCurrentFirstname.Text = Login_Logic.LoggedUser.Firstname;
            //    lbl_DashboardCurrentUserLastname.Text = Login_Logic.LoggedUser.Lastname;
            //    Display dashboard
            int[] values = _dashboard_logic.GetDashboardValues();
            lbl_DashboardUnresolvedText.Text += String.Format(" {0} / {1}", values[0], values[1]);
            lbl_DashboardOvertimeText.Text += String.Format(" {0} !", values[2]);

            //unresolved tickets circle
            cpc_DashboardUnresolvedTickets.CurrentValue = values[0];
            cpc_DashboardUnresolvedTickets.MaxValue = values[1];
            //Incidents past deadlines 
            cpc_DashboardOvertimeTickets.CurrentValue = values[2];
            cpc_DashboardOvertimeTickets.MaxValue = 20;
            cpc_DashboardOvertimeTickets.ProgressColor = Color.Red;
        }

        private void btn_DashboardLogout_Click(object sender, EventArgs e)
        {
            //    _login_Logic.LogoutUser();
            //    pnl_Dashboard.Visible = false;
            //    ReturnToLogin();
        }
        #endregion
        //private void pic_LoginReturn1_Click(object sender, EventArgs e)
        //{
        //    HideAllPanels();
        //}

        private void btn_ManageUsers_Click(object sender, EventArgs e)
        {

        }
        // fill comboxesof tickets and ticket overview
        public void FillComboboxes()
        {
            cbo_UserReportedBy.DisplayMember = "Fullname";
            cbo_UserReportedBy.DataSource = _user.GetnormalandSuperUser().Item1;
            // autofill textbox of the maketicketuser
          //  textBoxFirstname.Text = _currentuser.Firstname;
          //  textBoxLastname.Text = _currentuser.Lastname;
            //
           // comboBox_Priority.DataSource = Enum.GetValues(typeof(Priority));
            cbo_IncidentType.DataSource = Enum.GetValues(typeof(IncidentType));
            //foreach (Status status in Enum.GetValues(typeof(Status)))
            //{
            //    comboBox_TicketStatus1.Items.Add(status);
            //}
            cbo_HandeledBy.DisplayMember = "Fullname";
            cbo_HandeledBy.DataSource = _user.GetnormalandSuperUser().Item2;
            cbo_TicketPriority.DataSource = Enum.GetValues(typeof(Priority));
            cbo_SortPriority.DataSource = Enum.GetValues(typeof(Priority));
        }
        private void btn_Tickets_Click(object sender, EventArgs e)
        {
            // if user is normal user show other panels

            Loadlistview();
            
            FillComboboxes();
            pnl_TicketOverview.Visible = true;
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            pnl_Dashboard.Visible = true;
        }
        private void FillListview(List<Ticket> tickets, ListView listviews)
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
            lv_TicketOverview.Visible = false;
            pnl_TicketOfUserAdmin.Visible = true;
         
            Ticket ticket = (Ticket)lv_TicketOverview.SelectedItems[0].Tag;
            //  FillTicketAndComboBoxes(ticket);
            //  ShowComboBoxTickets();
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
    }
}
