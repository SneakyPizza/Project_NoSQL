using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using DAL;
using System.Text.RegularExpressions;

namespace Logic
{
    public class ForgotPassword_Logic
    {
        private string _currentResetCode;
        private const int _RESETCODELENGTH = 6;

        private Login_DAL _login_dal = Login_DAL.Instance;
        private Login_Logic _login_logic = Login_Logic.Instance;

        private static ForgotPassword_Logic _instance;
        //ForgotPassword_logic Singleton
        public static ForgotPassword_Logic Instance
        {
            get
            {
                if(_instance == null) { _instance = new ForgotPassword_Logic(); }
                return _instance;
            }
        }
        
        public void RemoveResetCode()
        {
            if(_currentResetCode != null) { _currentResetCode = null; }
        }
        //Sending a mail if the email exists
        public void SendMail(string email)
        {
            if (CheckMail(email))
            {
                SmtpClient client = SetupClient();
                client.Send(CreateMailMessage(email));
            }
            //We are not sending a error message if the mail isnt found due to security reasons

        }
        //checking if the filled in code is the same as the one that was send
        public bool ResetCodeCheck(string code)
        {
            return code == _currentResetCode;
        }
        //Setting up a outlook smtp server
        private SmtpClient SetupClient()
        {
            SmtpClient client = new SmtpClient();   //using system.net.mail
            client.Host = "smtp-mail.outlook.com";  //Set host server
            client.Port = 587;                      //Set port
            client.DeliveryMethod = SmtpDeliveryMethod.Network; 
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential("forgotpasswordnosqlproject1@outlook.com", "Test.Wachtwoord.99881!");
            client.EnableSsl = true;
            client.Credentials = credential;
            return client;
        }
        //Create mail message
        private MailMessage CreateMailMessage(string email)
        {
            string text = "Your reset code: ";
            MailMessage msg = new MailMessage("forgotpasswordnosqlproject1@outlook.com", email);
            msg.Subject = "Forgot password code";

            string code = GenerateRandomResetCode(_RESETCODELENGTH);
            _currentResetCode = code;
            msg.Body = text += code;
            msg.IsBodyHtml = true;
            return msg;
        }

        //Generates Random string of given length for resetting password.
        private string GenerateRandomResetCode(int resetCodeLength)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random r = new Random();
            string value = "";

            for(int i =0; i < resetCodeLength; i++)
            {
                int index = r.Next(0, chars.Length); //get index of random letter in chars
                value += chars[index];
            }
            return value;
        }

        //check if email exists
        private bool CheckMail(string email)
        {
            try
            {
                return _login_dal.CheckEmail(email);
            } catch(Exception e)
            {
                throw e;
            }
        }

        //Encrypt new password before updating
        public bool UpdateUserPassword(string email, string password)
        {
            try
            {
                password = _login_logic.EncryptPassword(password);
                _login_dal.UpdatePasswordWithUsername(email, password);
                return true;
            } catch(Exception e)
            {
                throw e;
            }
        }

        //Check if the given emailaddress is valid and return true or false
        public bool ValidEmailAdress(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
