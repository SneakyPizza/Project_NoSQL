using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using Model;

namespace DAL
{
    public class Login_DAL: Base
    {
        //Compare username
        // if true  -> compare password

        //password encryption in the logic layer 

        public bool LoginUser(string username, string password)
        {
            var db = _client.GetDatabase("Users"); //Insert database name
            IMongoCollection<User> collection = db.GetCollection<User>(""); //get collection of users

            var filter = Builders<User>.Filter.Eq("username", username);    //filter on username 

            List<User> list = collection.Find(filter).ToList(); //find username
            if(list.Count > 0)  //if the list has less then 1 it hasnt found the username
            {
                //username found
                if(list[0].Password == password)    //check password
                {
                    return true;
                }
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
            GetDatabase().GetCollection<User>("Users").InsertOne(user);
        }
    }
}
