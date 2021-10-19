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
        private static User _loggedUser;
        //Login_logic Singleton
        public static Login_Logic Instance
        {
            get
            {
                if (_login_logic == null) { _login_logic = new Login_Logic(); }
                return _login_logic;
            }
        }
        public static User LoggedUser { get { return _loggedUser; } set { if (_loggedUser == null) _loggedUser = value; } }
        public void LogoutUser()
        {
            if (_loggedUser != null)
            {
                _loggedUser = null;
            }
        }
        //Encrypt password with Bcrypt
        public string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        //Try to login user with trimmed username and password
        public User LoginUser(string username, string password)
        {
            try
            {
                username = username.Trim();
                password = password.Trim();
                return _login_dal.ReturnLoggingUser(username,password);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //Create a user form a Bson document
        public User CreateUserfromBson(BsonDocument doc)
        {
            try
            {
                BsonSerializer.Deserialize<User>(doc);
                return new User(
                    (ObjectId)doc["_id"],
                    doc["Username"].ToString(),
                    doc["Password"].ToString(),
                    doc["Firstname"].ToString(),
                    doc["Lastname"].ToString(),
                    (UserRole)doc["UserRole"].ToInt32(),
                    doc["Email"].ToString()
                    );
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
