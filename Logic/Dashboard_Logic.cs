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
        //Dashboard logic Singleton
        public static Dashboard_Logic Instance
        {
            get
            {
                if(_instance == null) { _instance = new Dashboard_Logic(); }
                return _instance;
            }
        }

        //Function tries to get all the tickets and adds them to a list.
        //After adding it processes the values and the return array with the values
        public int[] GetDashboardValues()
        {
            try
            {
                int[] values = new int[3];
                List<Ticket> tickets = DAL.RetrieveAllTickets();
                (int open, int total) = GetOpenAndTotalTicketsCount(tickets);
                int due = GetDueTickets(tickets);
                values[0] = open;
                values[1] = total;
                values[2] = due;
                return values;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Function returns a count of the tickets that are over due
        private int GetDueTickets(List<Ticket> tickets)
        {
            int count = 0;
            foreach (Ticket t in tickets)
            {
                if (t.PastDeadline && (t.Status != Status.Solved || t.Status != Status.Rejected)) { count++; }
            }
            return count;
        }

        //Function returns a tuple of a count of the currently open tickets and total amount of tickets
        private (int open, int total) GetOpenAndTotalTicketsCount(List<Ticket> tickets)
        {
            int count = 0;
            foreach (Ticket t in tickets)
            {
                if (t.Status != Status.Rejected && t.Status != Status.Solved) { count++; }
            }
            return (count, tickets.Count);
        }
    }
}
