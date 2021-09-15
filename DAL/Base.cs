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
        private IMongoDatabase _database;

        public Base()
        {
            // set connection string
            _client = new MongoClient(MongoClientSettings.FromConnectionString(ConfigurationManager.ConnectionStrings["Mongo"].ConnectionString));
            _database = _client.GetDatabase("SampleCluster");
        }

        

        public IMongoCollection<BsonDocument> getCollection(string collectionName)
        {
            return _database.GetCollection<BsonDocument>(collectionName);
        }

        //to test connection, remove later
        public List<BsonDocument> TestDocmentList()
        {
            return _client.ListDatabases().ToList();
        }
    }
}
