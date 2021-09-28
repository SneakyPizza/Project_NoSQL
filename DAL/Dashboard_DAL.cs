using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Dashboard_DAL: Base
    {
        private IMongoCollection<Ticket> GetDatabaseTickets()
        {
            return GetDatabase("ProjectNoSQL10").GetCollection<Ticket>("Tickets");
        }

        private (int open, int total) GetOpenAndTotalTickets(List<Ticket> tickets)
        {
            int count = 0;

            for(int i =0; i < tickets.Count; i++)
            {
                if(tickets[i].Status.ToLower() == "open")
                {
                    count++;
                }
            }
            return (count, tickets.Count);
        }

        private int GetDueTickets(List<Ticket> tickets)
        {
            int count = 0;
            for(int i=0; i < tickets.Count; i++)
            {
                if (tickets[i].PastDeadline)
                {
                    count++;
                }
            }
            return count;
        }

        public int[] GetDashboardValues()
        {
            List<Ticket> tickets = GetDatabaseTickets().Find(_ => true).ToList();
            
            int[] values = new int[3];
            (int count, int total) = GetOpenAndTotalTickets(tickets);
            int due = GetDueTickets(tickets);
            values[0] = count;
            values[1] = total;
            values[2] = due;
            return values;
        }
    }
}
