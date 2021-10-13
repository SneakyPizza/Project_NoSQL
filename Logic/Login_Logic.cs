using System;
using System.Collections.Generic;
using System.Text;
using BCrypt.Net;
using Model;
using DAL;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System.Linq;

namespace Logic
{
    public class Login_Logic
    {
        private Login_DAL _login_dal = Login_DAL.Instance;
        private static Login_Logic _login_logic;
        public static Login_Logic Instance
        {
            get
            {
                if(_login_logic == null) { _login_logic = new Login_Logic(); }
                return _login_logic;
            }
        }

        private static User _loggedUser;

        public static User LoggedUser { get { return _loggedUser; } set { if (_loggedUser == null) _loggedUser = value; } }
        public void LogoutUser()
        {
            if (_loggedUser != null)
            {
                _loggedUser = null;
            }
        }

        public string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
            //return BCrypt.BCryptHelper.HashPassword(password, )
        }

        public bool LoginUser(string username, string password)
        {
            try
            {
                username = username.Trim();
                password = password.Trim();
                return _login_dal.LoginUser(username, password);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public User CreateUserfromBson(BsonDocument doc)
        {
            try
            {
                BsonSerializer.Deserialize<User>(doc);
                List<ObjectId> ticketObjectIds = doc["Tickets"].AsBsonArray.Select(p => (ObjectId)p).ToList();
                // ObjectId id,string username, string password, string firstname, string lastname, UserRole userrole,List<ObjectId> tickets
                return new User(
                    (ObjectId)doc["_id"],
                    //ticketObjectIds,
                    doc["Username"].ToString(),
                    doc["Password"].ToString(),
                    doc["Firstname"].ToString(),
                    doc["LastName"].ToString(),
                    (UserRole)doc["UserRole"].ToInt32()
                    );
            } catch(Exception e)
            {
                throw e;
            }
        }
        

        //Created to insert a dummy user for testing purposes - Delete Later
        public void CreateDummyUser()
        {
            try
            {
                string p = "bobuser2";
                p = EncryptPassword(p);
                User u = new User("bob2", p, "bob2", "bobus2", (UserRole)1);
                _login_dal.InsertUser(u);
            } catch(Exception e)
            {
                throw e;
            }

        }
    }
}
