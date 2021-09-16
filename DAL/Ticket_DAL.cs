using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace DAL
{
   public class Ticket_DAL:Base
    {
        public void InsertTicket(Ticket ticket)
        {
            var collection = base.GetDatabase().GetCollection<Ticket>("Ticket");
            collection.InsertOne(ticket);
         
           

        }
    }
}
