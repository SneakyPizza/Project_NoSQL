using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using DAL;

namespace Logic
{
    public class User_Logic
    {
        //test connection, remove later
        public List<BsonDocument> getTest()
        {
            User_DAL dal = new User_DAL();
            return dal.TestDocmentList();
        }
    }
}
