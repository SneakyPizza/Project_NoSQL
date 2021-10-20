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
        public  (List<User>,List<User>) GetNormalAndAdminUsers(){

            var filter1 = Builders<User>.Filter.Eq("UserRole", UserRole.Admin);
            var filter2 = Builders<User>.Filter.Eq("UserRole", UserRole.User);
            List<User> normaluser = GetDatabase().GetCollection<User>("Users").Find(filter1).ToList();
            List<User> superuser = GetDatabase().GetCollection<User>("Users").Find(filter2).ToList();
            return (normaluser,superuser);

        }
        public List<User> GetUsers()
        {
            var filter = Builders<User>.Filter.Eq("UserRole",UserRole.Admin);
            List<User> Users = GetDatabase().GetCollection<User>("Users").Find(filter).ToList(); 
            return Users;
        }
        public List<User> GetNormalUsers()
        {
            var filter = Builders<User>.Filter.Eq("UserRole", UserRole.User);
            List<User> Users = GetDatabase().GetCollection<User>("Users").Find(filter).ToList();
            return Users;
        }
        public List<User> GetnewUser()
        {
            List<User> Users = GetDatabase().GetCollection<User>("Users").Find(new BsonDocument()).ToList();
            return Users;
        }

        public string GetCreatedByName(ObjectId TicketCreatedBy)
        {
            var collection = GetDatabase().GetCollection<User>("Users");
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("_id", TicketCreatedBy);
            User userCreatedBy = collection.Find(filter).First();
            return userCreatedBy.Fullname;
        }
        public bool UserCheck(string Username)
        {
            List<User> userlist = GetDatabase().GetCollection<User>("Users").Find(new BsonDocument()).ToList();
            foreach (User username in userlist)
            {
                if (Username == username.Username)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
