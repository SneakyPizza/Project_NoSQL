using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public class Dashboard_DAL :Ticket_DAL
    {
        private static Dashboard_DAL _instance;
        //Dashboard_DAL Singleton
        public static Dashboard_DAL Instance
        {
            get
            {
                if(_instance == null) { _instance = new Dashboard_DAL(); }
                return _instance;
            }
        }

        //returns a list of tickets
        public List<Ticket> GetAllTickets()
        {
            return new List<Ticket>(RetrieveAllTickets()); 
        }
    }
}
