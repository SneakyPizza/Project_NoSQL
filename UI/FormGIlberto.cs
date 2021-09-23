﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;
using DAL;

namespace UI
{
    public partial class FormGIlberto : Form
    {
        Ticket_Logic _tickets;
        User_Logic _user;
        public FormGIlberto()
        {
            _tickets = new Ticket_Logic();
            _user = new User_Logic();

            InitializeComponent();
            HidePanelTicketsOverview();
            FillcomboboxCreateTicket();
            listView_TicketsOverview.MouseDoubleClick += new MouseEventHandler(listView_TicketsOverview_MouseDoubleClick);
        }

        public void HidePanelTicketsOverview()
        {
            pnl_TicketOverview.Visible = false;
            pnl_Ticket1.Visible = false;
        }
        // show everything on ticketsoverview
        public void ShowPanelTicketsOverview()
        {
            pnl_TicketOverview.Visible = true;
        }
        public void ShowPanelTicket()
        {
            pnl_Ticket1.Visible = true;
        }
        // fill combobox of the create ticket panel
        public void FillcomboboxCreateTicket() 
        {
            comboBox_Priority.DataSource = Enum.GetValues(typeof(Priority));
            comboBox_IncidentType.DataSource = Enum.GetValues(typeof(IncidentType));
            comboBox_SortByPriority.DataSource = Enum.GetValues(typeof(Priority));
            _user.GetUsers().ForEach(user => comboBox_User.Items.Add(user.Firstname));
        }
        // send the ticket to the db
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket()
            {
                Title = txt_SubjectIncident.Text,
                CreationTime = DateTimePicker.Value, // choose date of created ticket
                IncidentType = Enum.GetName(typeof(IncidentType), (IncidentType)comboBox_IncidentType.SelectedValue),
                Priority = Enum.GetName(typeof(Priority), (Priority)comboBox_Priority.SelectedValue),
                Description = richTextBox_Description.Text,
                Deadline = DateTimePicker.Value.AddDays(double.Parse(comboBox_Deadline.Text.Where(Char.IsDigit).ToArray())),
                Status = Enum.GetName(typeof(Status), Status.Open) //convert enum to string // ticket is standaard open wanneer aangemaakt
            };
            _tickets.InsertTicket(ticket); // insert a ticket in de database
            MessageBox.Show("ticket has been inserted");
        }

        private void btn_TicketOverview_Click(object sender, EventArgs e)
        {
            ShowPanelTicketsOverview();
            FillListviewColumnHeaders();
            Loadlistview();
        }
        // fill listview with the tickets
        private void FillListview(List<Ticket> tickets)
        {
            listView_TicketsOverview.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                ListViewItem listview = new ListViewItem(ticket.Title);
                if (ticket.PastDeadline) { listview.ForeColor = Color.Red; }
                listview.Tag = ticket;
                listview.SubItems.Add(ticket.IncidentType.ToString());
                listview.SubItems.Add(ticket.Priority.ToString());
                listview.SubItems.Add(ticket.Status.ToString());
                listView_TicketsOverview.Items.AddRange(new ListViewItem[] { listview });
            }
        }
       
        // Load the listview with the tickets
        private void Loadlistview() {
            FillListview(_tickets.RetrieveAllTickets());
        }
        // fill the column headers of the listview
        private void FillListviewColumnHeaders()
        {
            List<String> ColumnHeader = new List<String>() { "Title", "IncidentType", "Priority", "Status" };
            foreach (String Header in ColumnHeader)
            {
                listView_TicketsOverview.Columns.Add(Header, 120, HorizontalAlignment.Left);
            }
        }
        // filter listview of the tickets
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            String keywords = richTextBox_Filter.Text;
            FillListview(_tickets.FilterList(keywords));
            MessageBox.Show("The list has been filtered");
        }
        // order tickets by priority
        private void btn_SortPriority_Click(object sender, EventArgs e)
        {
            String sortPriority = comboBox_SortByPriority.Text;
            FillListview(_tickets.OrderTickets(sortPriority));
        }
        public void ShowComboBoxTickets()
        {
            comboBox_TicketStatus.DataSource = Enum.GetValues(typeof(Priority));
        }
        // todo fill all fields en fix update button
        public void FillTicketAndComboBoxes(Ticket ticket)
        {
            richTextBox_TicketDescription1.Text = ticket.Description;
            comboBox_TicketStatus1.Text = ticket.Status;
            Txt_IncidentType1.Text = ticket.IncidentType;
            foreach (Status status in Enum.GetValues(typeof(Status))){
                comboBox_TicketStatus1.Items.Add(status);
            }
            richTextBox1_TIcketSolution1.Text = ticket.Solution;
        }
        // open selected ticket in listview and load the values of the ticket;
        private void listView_TicketsOverview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowPanelTicket();
            Ticket ticket = (Ticket)listView_TicketsOverview.SelectedItems[0].Tag;
            FillTicketAndComboBoxes(ticket);
            ShowComboBoxTickets();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            // check the changed values of the ticket and update them
            Ticket ticket = (Ticket)listView_TicketsOverview.SelectedItems[0].Tag;
            ticket.Status = comboBox_TicketStatus1.Text;
            ticket.Solution = richTextBox1_TIcketSolution1.Text;
            _tickets.UpdateTicket(ticket);
            MessageBox.Show("The ticket has been updated");
        }
        // return from the ticket to the ticket overview
        private void brn_BackButton_Click(object sender, EventArgs e)
        {
            pnl_Ticket1.Visible = false;
            Loadlistview();
        }
    }
}
