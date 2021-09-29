using System;
using System.Collections.Generic;
using System.Text;
using BCrypt;
using Model;
using DAL;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System.Linq;

namespace Logic
{
    public class Login_Logic
    {
        private Login_DAL login_dal = new Login_DAL();
        private static User _loggedUser;

        public static User LoggedUser { get { return _loggedUser; } set { if (_loggedUser == null) _loggedUser = value; } }
        public void LogoutUser()
        {
            if (_loggedUser != null)
            {
                _loggedUser = null;
            }
        }

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
                //Encrypt password before checking
                //password = EncryptPassword(password);
                if (login_dal.LoginUser(username, password))
                {
                    //Create logged_in user
                    return true;
                }
                return false;
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
                ObjectId[] ticketObjectIds = doc["Tickets"].AsBsonArray.Select(p => (ObjectId)p).ToArray();

                return new User(
                    (ObjectId)doc["_id"],
                    ticketObjectIds,
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
    }
}
