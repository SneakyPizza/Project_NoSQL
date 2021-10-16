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
        private Login_Logic _login_Logic = Login_Logic.Instance;
        private ForgotPassword_Logic _fp_logic = ForgotPassword_Logic.Instance;
        private string _emailReset;

        public FormYornie()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Username.Text) && !string.IsNullOrEmpty(tb_Password.Text))
            {
                //if (_login_Logic.LoginUser(tb_Username.Text, tb_Password.Text))
                //{
                //    MessageBox.Show("Succes");
                //    YornieDashboard dashboard = new YornieDashboard();
                //    dashboard.Show();
                //} else
                //{
                //    MessageBox.Show("Failed");
                //}
            } else
            {
                //_login_Logic.CreateDummyUser();
         
                _emailReset = "613441@student.inholland.nl";
                _fp_logic.SendMail(_emailReset);
                
                MessageBox.Show("Please fill in login details");
                
            }
        }

        private void btn_ConfirmNewPassword_Click(object sender, EventArgs e)
        {
            if((!string.IsNullOrEmpty(tb_NewPassword.Text) || !string.IsNullOrEmpty(tb_NewPasswordConfirm.Text)) && tb_NewPassword.Text == tb_NewPasswordConfirm.Text)
            {
                _fp_logic.UpdateUserPassword(_emailReset, tb_NewPasswordConfirm.Text);
            }
        }

        private void btn_CheckCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_CheckCode.Text))
            {
                if (CompareCode(tb_CheckCode.Text))
                {
                    MessageBox.Show("Correct code");
                } else
                {
                    MessageBox.Show("Incorrect code");
                }
            }
        }

        private bool CompareCode(string filledCode)
        {
            return _fp_logic.ResetCodeCheck(filledCode);
        }
    }
}
