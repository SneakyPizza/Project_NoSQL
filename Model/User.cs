﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User
    {
        private string _name;
        private string _password;
        private string _firstname;
        private string _lastname;
        private UserRole _userrole;
        

        public User(string username, string password, string firstname, string lastname, UserRole userrole)
        {
            Username = username;
            Password = password;
            _firstname = firstname;
            _lastname = lastname;
            _userrole = userrole;
        }

        public string Username { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public UserRole UserRole { get => _userrole; set => _userrole = value; }
    }
}
