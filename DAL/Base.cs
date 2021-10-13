using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public abstract class Base
    {
        private MongoClient _client;
        public Base()
        {
            // set connection string
            _client = new MongoClient(MongoClientSettings.FromConnectionString(ConfigurationManager.ConnectionStrings["Mongo"].ConnectionString));
        }
        // return database
        public IMongoDatabase GetDatabase() { return _client.GetDatabase("ProjectNoSQL10"); }
    }
}
