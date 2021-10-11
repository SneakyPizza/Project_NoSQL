using Model;
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
    public partial class FormYornie : Form
    {
        private Login_Logic _login_Logic = new Login_Logic();
        public FormYornie()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Username.Text) && !string.IsNullOrEmpty(tb_Password.Text))
            {
                if (_login_Logic.LoginUser(tb_Username.Text, tb_Password.Text))
                {
                    MessageBox.Show("Succes");
                    YornieDashboard dashboard = new YornieDashboard();
                    dashboard.Show();
                } else
                {
                    MessageBox.Show("Failed");
                }
            } else
            {
                //_login_Logic.CreateDummyUser();
                //ForgotPassword_Logic l = new ForgotPassword_Logic();
                //l.SendMail("613441@student.inholland.nl");
                MessageBox.Show("Please fill in login details");
            }
        }
    }
}
