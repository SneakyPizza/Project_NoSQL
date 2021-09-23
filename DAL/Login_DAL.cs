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
            var db = _client.GetDatabase("ProjectNoSQL10"); //Insert database name
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("Users"); //get collection of users

            var filter = Builders<BsonDocument>.Filter.Eq("Username", username);    //filter on username 

            List<BsonDocument> list = collection.Find(filter).ToList(); //find username
            if (list[0].GetElement("Password").ToString() == password)    //check password
            {
                return true;
            }


            return false;
        }

        private bool CheckUsername(string username, IMongoCollection<User> collection)
        {
            //if username is found get that collection and check the password
            var filter = Builders<User>.Filter.Eq("username", username);
            if(collection.Find(filter).ToList().Count >= 0)
            {
                return true;
            }
            return false;
        }

        public void InsertUser(User user)
        {
            GetDatabase("ProjectNoSQL10").GetCollection<User>("Users").InsertOne(user);
        }
    }
}
