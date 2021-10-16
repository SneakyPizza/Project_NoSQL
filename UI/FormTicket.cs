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
    public partial class FormTicket : Form
    {
        private Ticket _currentTicket;
        private Ticket_Logic ticket_Logic = Ticket_Logic.Instance;
        private User_Logic user_Logic = User_Logic.Instance;
        private NewMainForm _newMainform;
        private User _currentUser;
        public FormTicket() {
            InitializeComponent();
        }
        public FormTicket(Ticket _currentTicket)
        {
            this._currentTicket = _currentTicket;
            InitializeComponent();
            FillTicketAndComboBoxesOfTicketoverview(_currentTicket);
        }
        public FormTicket(NewMainForm _newMainform, User _currentUser)
        {
            this._newMainform = _newMainform;
            this._currentUser = _currentUser;
            InitializeComponent();
            FillComboboxesOfFrmTicket(); 
            lv_TicketOfNormalUser.MouseClick += new MouseEventHandler(lv_TicketOfNormalUser_MouseClick);
            LoadListview();
        }
        private void FillComboboxesOfFrmTicket() {
            cb_TicketIncidentType.DataSource = Enum.GetValues(typeof(IncidentType));
            cbo_TicketIncidentType.DataSource = Enum.GetValues(typeof(IncidentType));
            foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                cbo_ticketStatus.Items.Add(status);
            }
            cbo_TicketHandeldBy.DisplayMember = "Fullname";
            cbo_TicketHandeldBy.DataSource = user_Logic.GetNormalUser();
            foreach (Priority priority in Enum.GetValues(typeof(Priority)))
            {
                cbo_TIcketPriority.Items.Add(priority);
            }
        }
        public void FillTicketAndComboBoxesOfTicketoverview(Ticket ticket)
        {
          
            richtb_TicketDescription.Text = ticket.Description;
            cbo_ticketStatus.Text = ticket.Status.ToString();
            cbo_TicketIncidentType.Text = ticket.IncidentType.ToString();
            cbo_ticketStatus.SelectedItem = ticket.Status;
            cbo_ticketStatus.Text = ticket.Status.ToString();
            cbo_TIcketPriority.Text = ticket.Priority.ToString();
            richtb_TicketSolution.Text = ticket.Solution;
            lbl_UserFullname.Text = ticket_Logic.GetCreatedByName(_currentTicket).Item1.ToString();
            dtp_TicketCreationTime.Value = ticket.CreationTime;
            dtp_TicketDeadline.Value = ticket.Deadline;
        }
        // update the ticket
        private void btn_UpdateTicket_Click(object sender, EventArgs e)
        {
            _currentTicket.Status = (Status)cbo_ticketStatus.SelectedItem;
            _currentTicket.Solution = richtb_TicketSolution.Text;
            _currentTicket.Deadline = dtp_TicketDeadline.Value;
            ticket_Logic.UpdateTicket(_currentTicket);
            MessageBox.Show("The ticket has been updated");
            Close();
        }

        private void btn_CreateTicketNormalUser_Click(object sender, EventArgs e)
        {
            pnl_CreateTicketNormalUser.Visible = true;
        }
    
        public void LoadListview()
        {
            _newMainform.FillListview(ticket_Logic.TicketsOFuser(_currentUser), lv_TicketOfNormalUser);
        }

        private void btn_SubmitTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(_currentUser.Id, tb_TicketTitle.Text, richtb_TicketDescription.Text, (IncidentType)cb_TicketIncidentType.SelectedValue, Model.Priority.Normal);
            ticket_Logic.InsertTicket(ticket);
            MessageBox.Show("Ticket has been made");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("The application will be close if you press yes", "Close application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("The application is not closed. If you wish to sign in. Then press on the gardengroup logo on the top left of the application");
            }
        }

        private void lv_TicketOfNormalUser_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_SeeTicket.Visible = true;
            Ticket ticket = (Ticket)lv_TicketOfNormalUser.SelectedItems[0].Tag;
            richtb_TicketDescriptionNormalUser.Text = ticket.Description;
            richtb_TicketSolutionNormalUser.Text = ticket.Description;
            lbl_TicketTitle.Text = ticket.Title.ToString();
            lbl_TicketPriority.Text = ticket.Priority.ToString();
            lbl_TicketStatus.Text = ticket.Status.ToString();
            if (ticket.UserID.ToString() == "000000000000000000000000") { lbl_handeldBy.Text =  "None"; }
            else { lbl_handeldBy.Text = user_Logic.GetNameOfHandeldUser(ticket.UserID); }
            lbl_TicketCreationTime.Text = ticket.CreationTime.ToString();
            lbl_TicketDeadline.Text = ticket.Deadline.ToString();
        }

        private void pic_returnToTickerOverviewUser_Click(object sender, EventArgs e)
        {
            pnl_CreateTicketNormalUser.Visible = false;
            LoadListview();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pnl_SeeTicket.Visible = false;
        }
    }
}
