using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;


namespace Model
{
    public class Ticket
    {
        // public ObjectId Ticket_id { get; set; }
        // public ObjectId UserID { get; set; } // ticket aangemaakt door
       // public ObjectId CustomerID { get; set; } // gemaakt door
        public String Title { get; set; }
        public String Description { get; set; }
        public String IncidentType { get; set; }
        public String Deadline { get; set; }
        public String  Priority { get; set; }
        public String status { get; set; } 
        public DateTime CreationTime { get; set; } // tijd dat de ticket is aangemaakt
     
    }
}
