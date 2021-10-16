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
            FillTicketAndComboBoxes(_currentTicket);
        }
        public FormTicket(NewMainForm _newMainform, User _currentUser)
        {
            this._newMainform = _newMainform;
            this._currentUser = _currentUser;
            InitializeComponent();
            LoadListview();
        }

        public void FillTicketAndComboBoxes(Ticket ticket)
        {
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_CreateTicketNormalUser_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(_currentUser.Id, tb_TicketTitle.Text, richtb_TicketDescription.Text,Model.Priority.Normal);
            ticket_Logic.InsertTicket(ticket);
            MessageBox.Show("Ticket has been made");
        }
    
        public void LoadListview()
        {
            _newMainform.FillListview(ticket_Logic.TicketsOFuser(_currentUser), lv_TicketOfNormalUser);
        }
    }
}
