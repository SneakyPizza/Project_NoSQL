using System;
using System.Collections.Generic;
using System.Text;
using Model;
using MongoDB.Bson;

namespace DAL
{
    public class User_DAL: Base
    {
        
        public void InsertUser(User user)
        {
            BsonDocument doc = new BsonDocument()
            {
                {"firstname", user.Firstname },
                {"lastname", user.Lastname },
                {"username", user.Username },
                {"password", user.Password },
                {"role", user.UserRole },
            };

            GetDatabase("ProjectNoSQL10").GetCollection<BsonDocument>("Users").InsertOne(doc);
        }
    }
}
