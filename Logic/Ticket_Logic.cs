using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using DAL;
using Model;
namespace Logic
{
   public class Ticket_Logic
    {
        Ticket_DAL tickets = new Ticket_DAL();
        public void InsertTicket(Ticket ticket)
        {
            tickets.InsertTicket(ticket);
        }
    }
}
