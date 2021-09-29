﻿using System;
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
            GetDatabase().GetCollection<User>("Users").InsertOne(new User("VictorAdmin", "VictorAdmin", "VictorAdmin", "Victor4", UserRole.Admin, new List<ObjectId>()));
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
        public List<User> Login()
        {
            IList<FilterDefinition<User>> filtersList = new List<FilterDefinition<User>>();
            filtersList.Add(new BsonDocument("Username", "Victor2"));
            var builder = Builders<User>.Filter;
            List<User> Users = GetDatabase().GetCollection<User>("Users").Find(builder.And(filtersList)).ToList();
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
        // update the user column and fill it with all the tickets he has made
       
    }
}
