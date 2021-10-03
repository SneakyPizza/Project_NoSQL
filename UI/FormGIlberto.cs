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

namespace UI
{
    public partial class FormGIlberto : Form
    {
        Ticket_Logic _tickets;
        User_Logic _user;
        User _currentuser;
        public FormGIlberto()
        {
            _tickets = new Ticket_Logic();
            _user = new User_Logic();
            _currentuser = _user.GetUser();
            InitializeComponent();
            HidePanels();
            FillcomboboxCreateTicketAndTicketInformation();
         
            listView_TicketsOverview.MouseDoubleClick += new MouseEventHandler(listView_TicketsOverview_MouseDoubleClick);
            lv_TicketsofUser.MouseDoubleClick += new MouseEventHandler(lv_TicketsofUser_MouseDoubleClick);
        }
        // hide all panels
        public void HidePanels()
        {
            pnl_TicketOverview.Visible = false;
            pnl_Ticket1.Visible = false;
            pnl_UsermakeTicket.Visible = false;
            pnl_TicketsOfuser.Visible = false;
        }
        // show everything on ticketsoverview
        public void ShowPanelTicketsOverview()
        {
            pnl_TicketOverview.Visible = true;
        }
        // show the panel ticket
        public void ShowPanelTicket()
        {
            pnl_Ticket1.Visible = true;
        }
        // fill combobox of the create ticket panel
        public void FillcomboboxCreateTicketAndTicketInformation()
        {
            // autocomplete combobox
            comboBox1_UsersToTicket.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1_UsersToTicket.AutoCompleteSource = AutoCompleteSource.ListItems;
            //
            comboBox1_UsersToTicket.DisplayMember = "Fullname";
            comboBox1_UsersToTicket.DataSource = _user.GetNormalUser();
            // autofill textbox of the maketicketuser
            textBoxFirstname.Text = _currentuser.Firstname;
            textBoxLastname.Text = _currentuser.Lastname;
            //
            comboBox_Priority.DataSource = Enum.GetValues(typeof(Priority));
            comboBox_IncidentType.DataSource = Enum.GetValues(typeof(IncidentType));
            comboBox_SortByPriority.DataSource = Enum.GetValues(typeof(Priority));
            foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                comboBox_TicketStatus1.Items.Add(status);
            }
            comboBox_User.DisplayMember = "Fullname";
            comboBox_User.DataSource = _user.GetUsers();
        }
        // send the ticket to the db
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            User selectedUserID = (User)comboBox1_UsersToTicket.SelectedItem; // ticket for (Normal user)
            User selectedCreatedBy = (User)comboBox_User.SelectedItem; // ticket reportedby (Super User)
            Ticket ticket = new Ticket()
            {
                UserID = selectedUserID.Id,
                TicketCreatedBy = selectedCreatedBy.Id,
                Title = txt_SubjectIncident.Text,
                CreationTime = DateTimePicker.Value, // choose date of created ticket
                IncidentType = Enum.GetName(typeof(IncidentType), (IncidentType)comboBox_IncidentType.SelectedValue),
                Priority = Enum.GetName(typeof(Priority), (Priority)comboBox_Priority.SelectedValue),
                Description = richTextBox_Description.Text,
                Deadline = DateTimePicker.Value.AddDays(double.Parse(comboBox_Deadline.Text.Where(char.IsDigit).ToArray())),
                Status = Enum.GetName(typeof(Status), Status.Registered),
                Open = Enum.GetName(typeof(Open), Open.Yes), //convert enum to string // ticket is standaard open wanneer aangemaakt
                Solution = string.Empty
            };
            _tickets.InsertTicket(ticket);
            MessageBox.Show("ticket has been inserted");
        }

        private void btn_TicketOverview_Click(object sender, EventArgs e)
        {
            ShowPanelTicketsOverview();
            FillListviewColumnHeaders(listView_TicketsOverview);
            Loadlistview();
        }
        // fill listview with the tickets
        private void FillListview(List<Ticket> tickets,ListView listviews)
        {
            listviews.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                ListViewItem listview = new ListViewItem(ticket.Title);
                if (ticket.PastDeadline && ticket.Deadline != DateTime.Parse("01/01/0001 00:00:00")) { listview.ForeColor = Color.Red; }
                else if (ticket.Deadline == DateTime.Parse("01/01/0001 00:00:00")) { listview.ForeColor = Color.DarkOrange; }
                listview.Tag = ticket;
                listview.SubItems.Add(ticket.IncidentType.ToString());
                listview.SubItems.Add(ticket.Priority.ToString());
                listview.SubItems.Add(ticket.Status.ToString());
                listview.SubItems.Add(ticket.Open);
                listviews.Items.AddRange(new ListViewItem[] { listview });
                Console.ResetColor();
            }
        }

        // Load the listview with the tickets
        private void Loadlistview()
        {
            FillListview(_tickets.RetrieveAllTickets(), listView_TicketsOverview);
        }
        // fill the column headers of the listview
        private void FillListviewColumnHeaders(ListView listview)
        {
            List<string> ColumnHeader = new List<string>() { "Title", "IncidentType", "Priority", "Status" };
            foreach (string Header in ColumnHeader)
            {
                listview.Columns.Add(Header, 120, HorizontalAlignment.Left);
            }
        }
        // filter listview of the tickets
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            string keywords = richTextBox_Filter.Text;
            FillListview(_tickets.FilterList(keywords), listView_TicketsOverview);
            MessageBox.Show("The list has been filtered");
        }
        // order tickets by priority
        private void btn_SortPriority_Click(object sender, EventArgs e)
        {
            string sortPriority = comboBox_SortByPriority.Text;
            FillListview(_tickets.OrderTickets(sortPriority), listView_TicketsOverview);
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
            comboBox_TicketStatus1.SelectedItem = ticket.Status;
            comboBox_TicketStatus1.Text = ticket.Status.ToString();
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
        private void btn_makeTicketNormalUser_Click(object sender, EventArgs e)
        {
            pnl_UsermakeTicket.Visible = true;
        }
        private void btn_BackbuttonUserticket_Click(object sender, EventArgs e)
        {
            pnl_UsermakeTicket.Visible = false;
        }
        // normal user can enter a ticket
        private void btn_makeTicketUSer_Click(object sender, EventArgs e)
        {
           // User user = _user.GetUser();
            Ticket ticket = new Ticket();
            ticket.UserID = _currentuser.Id;
            ticket.Description = richTextBox_Userdescription.Text;
            ticket.Title = textBoxTicketTitle.Text;
            ticket.Status = Enum.GetName(typeof(Status), Status.Processing);
            ticket.Open = Enum.GetName(typeof(Open), Open.Yes);
            ticket.IncidentType = Enum.GetName(typeof(IncidentType), IncidentType.Hardware);
            ticket.Solution = string.Empty;
            ticket.Priority = Enum.GetName(typeof(Priority), Priority.Normal);
            ticket.CreationTime = DateTime.Now;
            _tickets.InsertTicket(ticket);
           // _tickets.TicketsOFuser(_currentuser);
            // _tickets.UpdateTicketListOfUser(user);
            MessageBox.Show("Ticket has been made");
        }
        private void Btn_Delete_Click_1(object sender, EventArgs e)
        {
            Ticket ticket = (Ticket)listView_TicketsOverview.SelectedItems[0].Tag;
            _tickets.DeleteTicket(ticket);
            MessageBox.Show("Ticket has been deleted");
            Loadlistview();
        }

        private void btn_SeeTicketsUser_Click(object sender, EventArgs e)
        {
            FillListviewColumnHeaders(lv_TicketsofUser);
            FillListview(_tickets.TicketsOFuser(_currentuser),lv_TicketsofUser);
            pnl_TicketsOfuser.Visible = true;
        }

        private void lv_TicketsofUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
