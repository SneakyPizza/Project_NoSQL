using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class FormYornie : Form
    {
        public FormYornie()
        {
            InitializeComponent();
        }

        private User CreateUser(string username, string password, string firstname, string lastname, UserRole role)
        {
            return new User(username, password, firstname, lastname, role);
        }
    }
}
