using System;
using System.Collections.Generic;
using System.Text;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DAL
{
    public class User_DAL : Base
    {
        private object collection;

        public void InsertUser()
        {
            User u = new User();
            u.name = "victor";
            u.lastname = "victorlastname";
            GetDatabase().GetCollection<User>("Users").InsertOne(u);
        }

        public User GetUser()
        {
            var collection = GetDatabase().GetCollection<User>("Users");
            var filter = Builders<User>.Filter.Eq("name","victor");
            var test = collection.Find(filter);
            User user = test.FirstOrDefault();

            return user;
        }
    }
}
