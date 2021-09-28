﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;


namespace Model
{
    public class User
    {
        private string _username;
        private string _password;
        private string _firstname;
        private string _lastname;
        private UserRole _userrole;
        private ObjectId[] _ticketIds;
        private ObjectId _id;
        

        public User(ObjectId id, ObjectId[] ticketids, string username, string password, string firstname, string lastname, UserRole userrole)
        {
            _id = id;
            _username = username;
            _password = password;
            _firstname = firstname;
            _lastname = lastname;
            _userrole = userrole;
            _ticketIds = ticketids;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public UserRole UserRole { get => _userrole; set => _userrole = value; }
        public ObjectId[] TicketIds { get => _ticketIds; set => _ticketIds = value; }
        public ObjectId Id { get => _id; set => _id = value; }
    }
}
