using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

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

        public void SendMail(string email)
        {
            //if email is found do ....
            SmtpClient client = new SmtpClient("MailHost");
            client.Send(CreateMailMessage(email));
        }


        private MailMessage CreateMailMessage(string email)
        {
            MailAddress from = new MailAddress("", ""); //fill in sendermail
            MailAddress to = new MailAddress(email, ""); //fill reciever mail
            string text = "Your reset code: ";

            MailMessage msg = new MailMessage();
            msg.From = from;
            msg.To.Add(to);
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
            //return a check DAL for found email.
            return true;
        }
    }
}
