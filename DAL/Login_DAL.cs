using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using Model;
using MongoDB.Bson;

namespace DAL
{
    public class Login_DAL: Base
    {
        //Compare username
        // if true  -> compare password

        //password encryption in the logic layer 

        public bool LoginUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Username", username);    //filter on username 
            BsonDocument collection = GetDatabaseBsonUsers().Find(filter).FirstOrDefault();

            if (collection.GetValue("Password", "n/a") == password)    //check password
            {
                return true;
            }
            return false;
        }

        private IMongoCollection<BsonDocument> GetDatabaseBsonUsers()
        {
            return GetDatabase("ProjectNoSQL10").GetCollection<BsonDocument>("Users");
        }

        public void InsertUser(User user)
        {
            GetDatabase("ProjectNoSQL10").GetCollection<User>("Users").InsertOne(user);
        }
    }
}
