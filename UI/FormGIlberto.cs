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
            InitializeComponent();

        }
        public void fillcombobox()
        {
            
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            // ticket wegsturen naar database
            Ticket_Logic tickets = new Ticket_Logic();
            Ticket ticket = new Ticket()
            {
                CreationTime = DateTime.Now,
                Title = txt_SubjectIncident.Text,
                Categorie = comboBox_IncidentType.Text,
                Priority = (Priority)Enum.Parse(typeof(Priority), comboBox_Priority.Text),
                Description = richTextBox_Description.Text,
          
            };

            tickets.InsertTicket(ticket);
        }
    }
}
