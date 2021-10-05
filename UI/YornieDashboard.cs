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
            Start();
        }

        private void YornieDashboard_Load(object sender, EventArgs e)
        {
            Start();
        }

        public void Start()
        {
            //Getting userdata
            //string Username = logic.GetLoggedUsername();
            //string userrole = logic.GetLoggedUserRole().ToString();
            //Display dashboard
            int[] values = logic.GetDashboardValues();
            lbl_openTickets.Text += String.Format(" {0} / {1}", values[0], values[1]);
            lbl_overTime.Text += String.Format(" {0} !", values[2]);

            //unresolved tickets circle
            UC_unresolved.CurrentValue = values[0];
            UC_unresolved.MaxValue = values[1];
            //Incidents past deadlines 
            UC_overTime.CurrentValue = values[2];
            UC_overTime.MaxValue = 20;
            UC_overTime.ProgressColor = Color.Red;
        }
    }
}
