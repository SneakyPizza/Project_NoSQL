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

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //test connection, remove later
            User_Logic logic = new User_Logic();
            foreach(var li in logic.getTest())
            {
                MessageBox.Show(li.GetValue(1).ToString());
            }
        }

    }
}
