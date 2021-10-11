using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using DAL;

namespace Logic
{
    public class ForgotPassword_Logic
    {
        //check if email exists
        //send email with random generated 4 characters
        //check if generated value that is send is the correct input
        //fill in new password x2 and update the user collection item with new password

        private string _currentResetCode;
        private const int _RESETCODELENGTH = 6;

        private Login_DAL login_dal = Login_DAL.Instance;

        public void SendMail(string email)
        {
            //if email is found do ....

            if (checkMail(email))
            {
                SmtpClient client = SetupClient();
                client.Send(CreateMailMessage(email));
            }
        }

        private bool ResetCodeCheck(string code)
        {
            return code == _currentResetCode;
        }

        private SmtpClient SetupClient()
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp-mail.outlook.com";
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential("forgotpasswordnosqlproject@outlook.com", "Test.Wachtwoord.99881!");
            client.EnableSsl = true;
            client.Credentials = credential;
            return client;
        }

        private MailMessage CreateMailMessage(string email)
        {
            string text = "Your reset code: ";
            MailMessage msg = new MailMessage("forgotpasswordnosqlproject@outlook.com", email);
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

        private bool checkMail(string email)
        {
            try
            {
                return login_dal.CheckEmail(email);
            } catch(Exception e)
            {
                throw e;
            }
        }
    }
}
