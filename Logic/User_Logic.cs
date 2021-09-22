using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using DAL;
using Model;

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

        private User CreateUser(string username, string password, string firstname, string lastname, UserRole role)
        {
            return new User(username, password, firstname, lastname, role);
        }
    }
}
