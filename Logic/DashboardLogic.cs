using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace Logic
{
    public class Dashboard_Logic
    {
        private Dashboard_DAL DAL = new Dashboard_DAL();

        public UserRole GetLoggedUserRole()
        {
            try
            {
                return Login_Logic.LoggedUser.UserRole;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetLoggedUsername()
        {
            try
            {
                return Login_Logic.LoggedUser.Username;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int[] GetDashboardValues()
        {
            try
            {
                return DAL.GetDashboardValues();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
