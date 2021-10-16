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
        public FormTicket(Ticket _currentTicket)
        {
            InitializeComponent();
            this._currentTicket = _currentTicket;
        }

        public void FillTicketAndComboBoxes(Ticket ticket)
        {
            richtb_TicketDescription.Text = ticket.Description;
            cbo_ticketStatus.Text = ticket.Status.ToString();
            cbo_TicketIncidentType.Text = ticket.IncidentType.ToString();
            cbo_ticketStatus.SelectedItem = ticket.Status;
            cbo_ticketStatus.Text = ticket.Status.ToString();
            richtb_TicketSolution.Text = ticket.Solution;
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            // check the changed values of the ticket and update them
            _currentTicket.Status = (Status)cbo_ticketStatus.SelectedItem;
            _currentTicket.Solution = richtb_TicketSolution.Text;
            _currentTicket.Deadline = dtp_TicketDeadline.Value;
            ticket_Logic.UpdateTicket(_currentTicket);
            MessageBox.Show("The ticket has been updated");
        }
    }
}
