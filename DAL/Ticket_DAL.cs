using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace DAL
{
   public class Ticket_DAL:Base
    {
        public void InsertTicket(Ticket ticket) // insert ticket in de database
        {
            GetDatabase().GetCollection<Ticket>("Ticket").InsertOne(ticket);
        }
    }
}
