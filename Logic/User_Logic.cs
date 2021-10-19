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
        public void InsertUser(string firstname, string lastname, string username, string password, UserRole role, string email)
        {
            try
            {
                password = _login_logic.EncryptPassword(password);
                dal.InsertUser(firstname, lastname, username, password, role, email);
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

                throw new Exception (e.Message);
            }
        }
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
    }
}
