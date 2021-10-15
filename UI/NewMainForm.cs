using System;
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
    public partial class NewMainForm : Form
    {
        private Login_Logic _login_Logic = Login_Logic.Instance;
        private ForgotPassword_Logic _fp_logic = ForgotPassword_Logic.Instance;
        private Dashboard_Logic _dashboard_logic = Dashboard_Logic.Instance;
        private Ticket_Logic ticket_Logic = Ticket_Logic.Instance;
        private User _currentUser;
        private string _emailReset;

        public NewMainForm()
        {
            InitializeComponent();
            //pnl_Dashboard.Visible = false;
        }
        private void HideAllPanels()
        {
            pnl_ForgotPassword.Visible = false;
            pnl_DashboardOptions.Visible = false;
            pnl_ForgotPasswordCode.Visible = false;
            pnl_ForgotPasswordNewPassword.Visible = false;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Password.Text) && !string.IsNullOrEmpty(tb_Username.Text))
            {
                if (_login_Logic.LoginUser(tb_Username.Text, tb_Password.Text))
                {
                    MessageBox.Show("Succes");
                    HideAllPanels();
                    pnl_Dashboard.Visible = true;
                    pnl_DashboardOptions.Visible = true;
                    StartDashboard();
                    //pnl_Dashboard.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill in login details");
            }
        }
        private void lbl_ForgotPassword_Click(object sender, EventArgs e)
        {
            pnl_ForgotPassword.Visible = true;
        }

        private void btn_ForgotPasswordConfirm_Click(object sender, EventArgs e)
        {
            string input = tb_ForgotPassword.Text.Trim();
            if (!string.IsNullOrEmpty(input) && _fp_logic.ValidEmailAdress(input))
            {
                _emailReset = input;
                _fp_logic.SendMail(_emailReset);
              //  HideAllPanels();
                pnl_ForgotPasswordCode.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Email");
            }
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
                ReturnToLogin();
            }
            else
            {

                MessageBox.Show("Invalid password");
                tb_ForgotPasswordNew.Clear();
                tb_ForgotPasswordConfirm.Clear();
            }
        }
        private void ReturnToLogin()
        {
            pnl_ForgotPassword.Visible = false;
            pnl_ForgotPasswordCode.Visible = false;
            pnl_ForgotPasswordNewPassword.Visible = false;
           // pnl_Login.Visible = true;
            _fp_logic.RemoveResetCode();
            if (_emailReset != null) { _emailReset = null; }
        }
        private void ReturnToLoginEvent(object sender, EventArgs e)
        {
            ReturnToLogin();
        }
        //#endregion

        #region Dashboard
        private void StartDashboard()
        {
         //   Getting userdata
         //   string Username = logic.GetLoggedUsername();
         //   string userrole = logic.GetLoggedUserRole().ToString();

         //   lbl_DashboardCurrentFirstname.Text = Login_Logic.LoggedUser.Firstname;
         //   lbl_DashboardCurrentUserLastname.Text = Login_Logic.LoggedUser.Lastname;
            //Display dashboard
            int[] values = _dashboard_logic.GetDashboardValues();
            lbl_DashboardUnresolvedText.Text += String.Format(" {0} / {1}", values[0], values[1]);
            lbl_DashboardOvertimeText.Text += String.Format(" {0} !", values[2]);

            //unresolved tickets circle
            cpc_DashboardUnresolvedTickets.CurrentValue = values[0];
            cpc_DashboardUnresolvedTickets.MaxValue = values[1];
            //Incidents past deadlines 
            cpc_DashboardOvertimeTickets.CurrentValue = values[2];
            cpc_DashboardOvertimeTickets.MaxValue = 20;
            cpc_DashboardOvertimeTickets.ProgressColor = Color.Red;
        }

        private void btn_DashboardLogout_Click(object sender, EventArgs e)
        {
        //    _login_Logic.LogoutUser();
        //    pnl_Dashboard.Visible = false;
        //    ReturnToLogin();
        }
        #endregion
        private void btn_DashboardOpenTickets_Click(object sender, EventArgs e)
        {
            //Gilberto
        }
        private void btn_DashboardOpenUsers_Click(object sender, EventArgs e)
        {
            //Taph
        }
        private void pic_LoginReturn1_Click(object sender, EventArgs e)
        {
            HideAllPanels();
        }

        private void btn_ManageUsers_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tickets_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            pnl_Dashboard.Visible = true;
        }
    }
}
