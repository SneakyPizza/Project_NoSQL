using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;


namespace Model
{
    public class Ticket
    {

        // public ObjectId UserID { get; set; } // user that creates ticket and makes ticket. is split by user role
        public ObjectId id { get; set; }// om tickets te inserten en op te halen
        public String Title { get; set; }
        public String Description { get; set; }
        public String IncidentType { get; set; }
        public DateTime Deadline { get; set; }
        public String  Priority { get; set; }
        public String Status { get; set; } 
        public Boolean PastDeadline { get { return (DateTime.Now > Deadline); } }
        public DateTime CreationTime { get; set; } // tijd dat de ticket is aangemaakt
        public String Solution { get; set; } // solution of the ticket problem

    }
}
