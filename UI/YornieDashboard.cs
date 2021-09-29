using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class YornieDashboard : Form
    {
        private Dashboard_Logic logic = new Dashboard_Logic();
        public YornieDashboard()
        {
            InitializeComponent();
        }

        public void Form_Load()
        {
            Start();
        }

        public void Start()
        {
            //Getting userdata
            string Username = logic.GetLoggedUsername();
            string userrole = logic.GetLoggedUserRole().ToString();
            //Display dashboard
            int[] values = logic.GetDashboardValues();
            lbl_openTickets.Text += String.Format(" {0} / {1}", values[0], values[1]);
            lbl_overTime.Text += String.Format(" {0} !", values[2]);
            //unresolved tickets circle

            //Incidents past deadlines 
        }
    }
}
