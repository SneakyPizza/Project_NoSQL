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
        public static Dashboard_DAL Instance
        {
            get
            {
                if(_instance == null) { _instance = new Dashboard_DAL(); }
                return _instance;
            }
        }

        private IMongoCollection<Ticket> GetDatabaseTickets()
        {
            return GetDatabase("ProjectNoSQL10").GetCollection<Ticket>("Tickets");
        }

        private (int open, int total) GetOpenAndTotalTickets()
        {
            int count = 0;
            List<Ticket> tickets = RetrieveTickets();
            int total = tickets.Count;
            return (count, total);
        }

        private int GetDueTickets()
        {
            int count = 0;
            foreach (Ticket ticket in RetrieveTickets())
            {
                if (ticket.PastDeadline) {
                    count++;
                }
            }
            return count;
        }

        public int[] GetDashboardValues()
        {
            int[] values = new int[3];
            (int count, int total) = GetOpenAndTotalTickets();
            int due = GetDueTickets();
            values[0] = count;
            values[1] = total;
            values[2] = due;
            return values;
        }
    }
}
