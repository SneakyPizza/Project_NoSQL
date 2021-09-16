using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User
    {
        private string _name;
        private string _password;

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
