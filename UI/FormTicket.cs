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
            //richTextBox_TicketDescription1.Text = ticket.Description;
            //comboBox_TicketStatus1.Text = ticket.Status.ToString();
            //Txt_IncidentType1.Text = ticket.IncidentType.ToString();
            //comboBox_TicketStatus1.SelectedItem = ticket.Status;
            //comboBox_TicketStatus1.Text = ticket.Status.ToString();
            //richTextBox1_TIcketSolution1.Text = ticket.Solution;
            //if (ticket.Deadline == DateTime.Parse("01/01/0001 00:00:00"))
            //{
            //    dateTimePicker_TicketDeadline.Checked = false;
            //    dateTimePicker_TicketDeadline.CustomFormat = " ";
            //    dateTimePicker_TicketDeadline.Format = DateTimePickerFormat.Custom;
            //}
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
