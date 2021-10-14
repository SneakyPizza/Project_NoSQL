using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace Logic
{
    public class Dashboard_Logic
    {
        private Dashboard_DAL DAL = Dashboard_DAL.Instance;

        private static Dashboard_Logic _instance;
        public static Dashboard_Logic Instance
        {
            get
            {
                if(_instance == null) { _instance = new Dashboard_Logic(); }
                return _instance;
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
