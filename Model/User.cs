using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
namespace Model
{
  public class User
    {
        private string _username;
        private string _password;
        private string _firstname;
        private string _lastname;
        private UserRole _userrole;
        //private ObjectId[] _ticketIds;
        private ObjectId _id;
        private string _email;
        

        public User(ObjectId id, string username, string password, string firstname, string lastname, UserRole userrole)
        {
            _username = username;
            _password = password;
            _firstname = firstname;
            _lastname = lastname;
            _userrole = userrole;
        }

        public User(string username, string password, string firstname, string lastname, UserRole userrole)
        {
            _username = username;
            _password = password;
            _firstname = firstname;
            _lastname = lastname;
            _userrole = userrole;
        }

        public User(string username, string password, string firstname, string lastname, UserRole userrole, string email)
        {
            _username = username;
            _password = password;
            _firstname = firstname;
            _lastname = lastname;
            _userrole = userrole;
            _email = email;
        }
        
        public string Fullname { get { return string.Format("{0}  {1}", Firstname, Lastname); } }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public UserRole UserRole { get => _userrole; set => _userrole = value; }
        public string Email { get => _email; set => _email = value; }
        public ObjectId Id { get => _id; set => _id = value; }
    }
}
