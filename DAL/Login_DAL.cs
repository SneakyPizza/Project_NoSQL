using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using Model;
using MongoDB.Bson;
using BCrypt;

namespace DAL
{
    public class Login_DAL: Base
    {
        private static Login_DAL instance;
        //Login_DAL Singleton
        public static Login_DAL Instance
        {
            get
            {
                if (instance == null) { instance = new Login_DAL(); }
                return instance;
            }
        }
        //Find and authenticate login credentials
        public User ReturnLoggingUser(string username, string password)
        {
            var filter = Builders<User>.Filter.Eq("Username", username);    //filter on username 
            User user = GetDatabase().GetCollection<User>("Users").Find(filter).FirstOrDefault(); //gets the document of the corresponding user
            if (user != null && AuthenticateLogin(password, user.Password))
            {
                return user;
            }
            return null;
        }

        //Verify the filled password with the storedpassword through bcrypt
        private bool AuthenticateLogin(string filledpassword, string storedpassword)
        {
            return BCrypt.Net.BCrypt.Verify(filledpassword, storedpassword);
        }

        private IMongoCollection<BsonDocument> GetDatabaseBsonUsers()
        {
            var db = GetDatabase("ProjectNoSQL10").GetCollection<BsonDocument>("Users");
            return db;
        }

        //Check if email exists in database
        public bool CheckEmail(string email)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Email", email);
            BsonDocument coll = GetDatabaseBsonUsers().Find(filter).FirstOrDefault();
            if(coll == null)
            {
                return false;
            }
            return email == coll.GetValue("Email", "n/a").ToString();
        }
        //Updating Password of correspoding user
        public void UpdatePasswordWithUsername(string email, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Email", email);
            var update = Builders<BsonDocument>.Update.Set("Password", password );
            GetDatabaseBsonUsers().UpdateOne(filter, update);
        }
    }
}
