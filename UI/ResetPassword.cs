﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace UI
{
    public partial class ResetPassword : Form
    {
        private Login_Logic _login_Logic = Login_Logic.Instance;
        private ForgotPassword_Logic _fp_logic = ForgotPassword_Logic.Instance;
        private string _emailReset;
        public ResetPassword()
        {
            InitializeComponent();
            pnl_ForgotPassword.Visible = true;
        }

        private void btn_ForgotPasswordConfirm_Click(object sender, EventArgs e)
        {
            string input = tb_ForgotPassword.Text.Trim();
            if (!string.IsNullOrEmpty(input) && _fp_logic.ValidEmailAdress(input))
            {
                _emailReset = input;
                _fp_logic.SendMail(_emailReset);
                pnl_ForgotPasswordCode.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Email");
            }
        }

        private void pic_LoginReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ForgotPasswordCodeConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_ForgotPasswordCode.Text))
            {
                if (_fp_logic.ResetCodeCheck(tb_ForgotPasswordCode.Text))
                {
                    MessageBox.Show("Correct code");
                    pnl_ForgotPasswordNewPassword.Visible = true;
                }
                else
                {
                    MessageBox.Show("Incorrect code");
                }
            }
        }

        private void btn_ForgotPasswordConfirmNewPassword_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(tb_ForgotPasswordNew.Text) || !string.IsNullOrEmpty(tb_ForgotPasswordConfirm.Text)) && tb_ForgotPasswordConfirm.Text.Trim() == tb_ForgotPasswordNew.Text.Trim())
            {
                _fp_logic.UpdateUserPassword(_emailReset, tb_ForgotPasswordConfirm.Text.Trim());
                MessageBox.Show("Your password has succesfully been changed!");
                Close();
            }
            else
            {

                MessageBox.Show("Invalid password");
                tb_ForgotPasswordNew.Clear();
                tb_ForgotPasswordConfirm.Clear();
            }
        }
    }
}
