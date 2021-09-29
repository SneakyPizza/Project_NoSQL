using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;


namespace Model
{
    public class Ticket
    {
        public ObjectId UserID { get; set; } // user that creates ticket and makes ticket. is split by user role
        public ObjectId id { get; set; } // take and send tickets from the database
        public ObjectId TicketCreatedBy { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreationTime { get; set; } // tijd dat de ticket is aangemaakt
        public string Title { get; set; }
        public string Description { get; set; }
        public string IncidentType { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Solution { get; set; } // solution of the ticket problem
        public bool PastDeadline { get { return (DateTime.Now > Deadline); } }
       


    }
}
