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
using DAL;

namespace UI
{
    public partial class FormGIlberto : Form
    {
        public FormGIlberto()
        {
            Base database = new Base();
            User_Logic logic = new User_Logic();
            
            InitializeComponent();
            Fillcombobox();

        }
        
        public void Fillcombobox() // fill combobox with the enum values
        {
            comboBox_Priority.DataSource = Enum.GetValues(typeof(Priority));
            comboBox_IncidentType.DataSource = Enum.GetValues(typeof(IncidentType));
           // comboBox_Deadline.DataSource = Enum.GetValues(typeof(Deadlines));

        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            // ticket wegsturen naar database
            Ticket_Logic tickets = new Ticket_Logic();
            Ticket ticket = new Ticket()
            {
                Title = txt_SubjectIncident.Text,
                CreationTime = DateTimePicker.Value, // choose date of created ticket
                IncidentType = Enum.GetName(typeof(IncidentType), (IncidentType)comboBox_IncidentType.SelectedValue),
                Priority = Enum.GetName(typeof(Priority), (Priority)comboBox_Priority.SelectedValue),
                Description = richTextBox_Description.Text, 
                Deadline = comboBox_Deadline.Text,
                status = Enum.GetName(typeof(Status), Status.Open) //convert enum to string // ticket is standaard open wanneer aangemaakt
            };

            tickets.InsertTicket(ticket);
            MessageBox.Show("ticket has been inserted");
        }
    }
}
