using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using DAL;
using Model;
using MongoDB.Driver;

namespace Logic
{
   public class SortTicket_Logic
    {
        Ticket_DAL _tickets = new Ticket_DAL();

        // insert a new ticket in the database
        private static SortTicket_Logic _ticket_logic;
        public static SortTicket_Logic Instance
        {
            get
            {
                if (_ticket_logic == null) { _ticket_logic = new SortTicket_Logic(); }
                return _ticket_logic;
            }
        }
        public List<Ticket> OrderTickets(Priority OrderPriority)
        {
            List<Ticket> tickets = _tickets.RetrieveTickets();
            tickets.Sort((p, q) => p.Priority.CompareTo(q.Priority));
            tickets.Sort((p, q) => q.Priority.CompareTo(OrderPriority));
            return tickets;
        }
    }
}
