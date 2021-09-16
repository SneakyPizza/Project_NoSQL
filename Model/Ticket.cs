using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;


namespace Model
{
    public class Ticket
    {
        public ObjectId _id { get; set; }
        public ObjectId CustomerID { get; set; } // gemaakt door
        public string Title { get; set; }
        public string Description { get; set; }
        public string Categorie { get; set; }
        public String Deadline { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreationTime { get; set; } // tijd dat de ticket is aangemaakt
        public ObjectId UserID { get; set; } // ticket aangemaakt door
    }
}
