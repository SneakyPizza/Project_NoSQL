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
        private IMongoCollection<User> GetDatabaseUser()
        {
            return GetDatabase().GetCollection<User>("Users");
        }
        public void InsertUser(string firstname, string lastname, string username, string password,UserRole role, string email)
        {
            GetDatabase().GetCollection<User>("Users").InsertOne(new User(firstname, lastname,username,password , role, email));
        }

        public void UpdateUser(string oldUserName, string firstname, string lastname, string username, string password, UserRole role, string email)
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("Username", oldUserName);
            UpdateDefinition<User> update = Builders<User>.Update.Set("UserRole", role)
                .Set("Username", username)
                .Set("Password", password)
                .Set("Firstname", firstname)
                .Set("Lastname", lastname)
                .Set("Email", email);
            GetDatabaseUser().UpdateOne(filter, update);
        }
        public void DeleteUser(string username)
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("Username", username);
            GetDatabaseUser().DeleteOne(filter);
        }

        public List<User> GetUsers()
        {
            IList<FilterDefinition<User>> filtersList = new List<FilterDefinition<User>>();
            filtersList.Add(new BsonDocument("UserRole", 1));
            var builder = Builders<User>.Filter;
            List<User> Users = GetDatabase().GetCollection<User>("Users").Find(builder.And(filtersList)).ToList();
            return Users;
        }
        public List<User> Login()
        {
            IList<FilterDefinition<User>> filtersList = new List<FilterDefinition<User>>();
            filtersList.Add(new BsonDocument("Username", "Victor2"));
            var builder = Builders<User>.Filter;
            List<User> Users = GetDatabase().GetCollection<User>("Users").Find(builder.And(filtersList)).ToList();
            return Users;
        }
        public List<User> GetnewUser()
        {
            List<User> Users = GetDatabase().GetCollection<User>("Users").Find(new BsonDocument()).ToList();
            return Users;
        }
        public User GetUser()
        {
            var collection = GetDatabase().GetCollection<User>("Users");
            var filter = Builders<User>.Filter.Eq("Firstname", "Victor2");
            var test = collection.Find(filter);
            User user = test.FirstOrDefault();
            return user;
        }
       
    }
}
