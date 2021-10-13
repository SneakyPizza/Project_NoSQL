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
        private static User_Logic _uniqueInstance;

        public static User_Logic UniqueInstance
        {
            get
            {
                if (_uniqueInstance == null) { _uniqueInstance = new User_Logic(); }
                return _uniqueInstance;
            }
        }

        public List<User> GetUsers()
        {
            try
            {
                return dal.GetUsers();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // get single user
        public User GetUser()
        {
            try
            {
                return dal.GetUser();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<User> GetNormalUser()
        {
            try
            {
              //  dal.InsertUser();
                return dal.GetNormalUsers();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
