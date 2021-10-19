using System;
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
            //_currentuser = _user.GetUser();

            //DUMMY USER
            _currentuser = new User("Remove", "test", "Remove", "test", 0);

            InitializeComponent();
            HidePanels();

            FillcomboboxCreateTicketAndTicketInformation();
            listView_TicketsOverview.MouseDoubleClick += new MouseEventHandler(listView_TicketsOverview_MouseDoubleClick);
            lv_TicketsofUser.MouseDoubleClick += new MouseEventHandler(lv_TicketsofUser_MouseDoubleClick);
            dateTimePicker_TicketDeadline.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
        }
        // hide all panels
        public void HidePanels()
        {
            pnl_TicketOverview.Visible = false;
            pnl_Ticket1.Visible = false;
            pnl_UsermakeTicket.Visible = false;
            pnl_TicketsOfuser.Visible = false;
            pnl_CurrentTicketOfUser.Visible = false;
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

        public void ShowPanelCurrentTicketOfUser()
        {
            pnl_CurrentTicketOfUser.Visible = true;
        }
        public void FillcomboboxCreateTicketAndTicketInformation()
        {
            listView_TicketsOverview.FullRowSelect = true;
            // autocomplete combobox
            comboBox1_UsersToTicket.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1_UsersToTicket.AutoCompleteSource = AutoCompleteSource.ListItems;
            //
            
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
            //comboBox_User.DataSource = _user.InsertUser();
        }
        // send the ticket to the db
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            User selectedUserID = (User)comboBox1_UsersToTicket.SelectedItem; // ticket for (Normal user)
            User selectedCreatedBy = (User)comboBox_User.SelectedItem; // ticket reportedby (Super User)
            Ticket ticket = new Ticket(selectedUserID.Id, selectedCreatedBy.Id,
                DateTimePicker.Value.AddDays(double.Parse(comboBox_Deadline.Text.Where(char.IsDigit).ToArray())),
                DateTimePicker.Value, txt_SubjectIncident.Text, richTextBox_Description.Text, string.Empty, (IncidentType)comboBox_IncidentType.SelectedValue, (Priority)comboBox_Priority.SelectedValue, Status.Processing);
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
        private void FillListview(List<Ticket> tickets, ListView listviews)
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
                listview.SubItems.Add(ticket.IsCompleted);
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
            List<string> ColumnHeader = new List<string>() { "Title", "IncidentType", "Priority", "Status", "Completed" };
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
            comboBox_TicketStatus1.Text = ticket.Status.ToString();
            Txt_IncidentType1.Text = ticket.IncidentType.ToString();
            comboBox_TicketStatus1.SelectedItem = ticket.Status;
            comboBox_TicketStatus1.Text = ticket.Status.ToString();
            richTextBox1_TIcketSolution1.Text = ticket.Solution;
            if (ticket.Deadline == DateTime.Parse("01/01/0001 00:00:00")) {
                dateTimePicker_TicketDeadline.Checked = false;
                dateTimePicker_TicketDeadline.CustomFormat = " ";
                dateTimePicker_TicketDeadline.Format = DateTimePickerFormat.Custom;
            }
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
            ticket.Status = (Status)comboBox_TicketStatus1.SelectedItem;
            ticket.Solution = richTextBox1_TIcketSolution1.Text;
            ticket.Deadline = dateTimePicker_TicketDeadline.Value;
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
            Ticket ticket = new Ticket(_currentuser.Id, textBoxTicketTitle.Text, richTextBox_Userdescription.Text, (IncidentType)comboBox_IncidentType.SelectedValue, Priority.Normal);
            _tickets.InsertTicket(ticket);
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
            FillListview(_tickets.TicketsOFuser(_currentuser), lv_TicketsofUser);
            pnl_TicketsOfuser.Visible = true;
        }
        private void lv_TicketsofUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnl_CurrentTicketOfUser.Visible = true;
            Ticket ticket = (Ticket)lv_TicketsofUser.SelectedItems[0].Tag;
            lbl_CompletedTicketUser.Text = ticket.IsCompleted.ToString();
            lbl_TicketStatusUser.Text = ticket.Status.ToString();
           // lbl_ReportedBy.Text = _tickets.GetCreatedByName(ticket);
            lbl_CreationTime.Text = ticket.CreationTime.ToString();
            lbl_Deadline.Text = ticket.Deadline.ToString();
            richTextBox_userTicketDescription.Text = ticket.Description;
            richTextBox_TicketUserSolution.Text = ticket.Solution;
        }
        private void btn_TicketUserbuttonback_Click(object sender, EventArgs e)
        {
            pnl_CurrentTicketOfUser.Visible = false;
        }
        private void btn_backButtonPnlTicketListOfUser_Click(object sender, EventArgs e)
        {
            pnl_TicketsOfuser.Visible = false;
        }
        void Dtp_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_TicketDeadline.Format = DateTimePickerFormat.Long;
        }
        public void Fill()
        {
            comboBox_TicketHandeldBy.DisplayMember = "Fullname";
            comboBox_TicketHandeldBy.DataSource =  _user.GetUsers();
        }

       
    }
}
