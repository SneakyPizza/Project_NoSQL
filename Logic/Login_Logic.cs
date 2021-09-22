using System;
using System.Collections.Generic;
using System.Text;
using BCrypt;
using Model;
using DAL;

namespace Logic
{
    public class Login_Logic
    {
        private Login_DAL login_dal = new Login_DAL();

        private string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public void InsertUser(User user)
        {
            try
            {
                user.Password = EncryptPassword(user.Password);
                login_dal.InsertUser(user);
                //insert user
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool LoginUser(string username, string password)
        {
            try
            {
                if (login_dal.LoginUser(username, password))
                {
                    return true;
                }
                return false;
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
