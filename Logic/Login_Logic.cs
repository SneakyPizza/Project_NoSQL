using System;
using System.Collections.Generic;
using System.Text;
using BCrypt;

namespace Logic
{
    public class Login_Logic
    {
        private string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
