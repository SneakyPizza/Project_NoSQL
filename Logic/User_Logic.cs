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
        private Login_Logic _login_logic = Login_Logic.Instance; 
        User_DAL dal = new User_DAL();

        private static User_Logic _user_logic;
        public static User_Logic Instance
        {
            get
            {
                if (_user_logic == null) { _user_logic = new User_Logic(); }
                return _user_logic;
            }
        }
        public void InsertUser(string username, string password, string firstname, string lastname, UserRole role, string email)
        {
            try
            {
                password = _login_logic.EncryptPassword(password);
                dal.InsertUser(username, password, firstname, lastname, role, email);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateUser(string oldUserName, string firstname, string lastname, string username, string password, UserRole role, string email)
        {
            try
            {
                dal.UpdateUser(oldUserName, firstname, lastname, username, password, role, email);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteUser(String user)
        {
            try
            {
                dal.DeleteUser(user);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public (List<User>, List<User>) GetnormalandSuperUser()
        {
            try
            {
               return dal.GetNormalAndAdminUsers();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<User> GetnewUser()
        {
            try
            {
                return dal.GetnewUser();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
        public string GetNameOfHandeldUser(ObjectId TicketHandeldBy)
        {
            try
            {
                return dal.GetCreatedByName(TicketHandeldBy);
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
                return dal.GetNormalUsers();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool UserCheck(string username)
        {
            try
            {
                return dal.UserCheck(username);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public bool EmailCheck(string email)
        {
            try
            {
                return dal.EmailCheck(email);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
