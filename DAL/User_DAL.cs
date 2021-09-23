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
        public void InsertUser()
        {
            GetDatabase().GetCollection<User>("Users").InsertOne(new User("Victor","Victor","Victor","Victor", UserRole.User));
        }

        public List<User> GetUsers()
        {
            IList<FilterDefinition<User>> filtersList = new List<FilterDefinition<User>>();
            filtersList.Add(new BsonDocument("UserRole", 0));
            var builder = Builders<User>.Filter;
            List<User> Users = GetDatabase().GetCollection<User>("Users").Find(builder.And(filtersList)).ToList();
            Login();
            return Users;
        }
        public List<User> Login()
        {
            IList<FilterDefinition<User>> filtersList = new List<FilterDefinition<User>>();
            filtersList.Add(new BsonDocument("Username", "Victor"));
            var builder = Builders<User>.Filter;
            List<User> Users = GetDatabase().GetCollection<User>("Users").Find(builder.And(filtersList)).ToList();
            return Users;
        }
        public User GetUser()
        {
            var collection = GetDatabase().GetCollection<User>("Users");
            var filter = Builders<User>.Filter.Eq("Firstname", "Victor");
            var test = collection.Find(filter);
            User user = test.FirstOrDefault();

            return user;
        }
    }
}
