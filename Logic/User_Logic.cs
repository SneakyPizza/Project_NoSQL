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
        User_DAL dal = new User_DAL();

        public User_Logic()
        {
           // dal.InsertUser();
            dal.GetUser();
        }
      
    }
}
