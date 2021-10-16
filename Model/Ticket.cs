using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;


namespace Model
{
    public class Ticket
    {
        private ObjectId _userID;
        private ObjectId _id;
        private ObjectId _HandeldBy;
        private DateTime _deadLine;
        private DateTime _creationTime;
        private string _title;
        private string _description;
        private string _solution;
        private IncidentType _incidentType;
        private Priority _priority;
        private Status _status;

        // ticket super user
        public Ticket(ObjectId userID, ObjectId HandeldBy, DateTime deadLine, DateTime creationTime, string title, string description, string solution, IncidentType incidentType, Priority priority, Status status)
        {
            _userID = userID;
            _HandeldBy = HandeldBy;
            _deadLine = deadLine;
            _creationTime = creationTime;
            _title = title;
            _description = description;
            _incidentType = incidentType;
            _priority = priority;
            _status = status;
            _solution = solution;
        }
        // ticket normaluser
        public Ticket(ObjectId userID, string title, string description, Priority priority)
        {
            _userID = userID;
            _creationTime = DateTime.Now;
            _title = title;
            _description = description;
            _priority = priority;
            _status = Status.Processing;
            _deadLine = CreationTime.AddDays(7);
            _solution = string.Empty;
        }
        // return true if ticket is not closed
        public bool Completed
        {
            get
            {
                return (_status == Status.Registered) || (_status == Status.Processing)
                        || (_status == Status.OnHold) || (_status == Status.Rejected);
            }
        }
        public string IsCompleted
        {
            get
            {
                if (Completed) { return "No"; }
                return "Yes";
            }
        }
        public ObjectId UserID { get => _userID; set => _userID = value; } // user that creates ticket and makes ticket. is split by user role
        public ObjectId Id { get => _id; set => _id = value; } // take and send tickets from the database
        public ObjectId HandeldBy { get => _HandeldBy; set => _HandeldBy = value; }
        public DateTime Deadline { get => _deadLine; set => _deadLine = value; }
        public DateTime CreationTime { get => _creationTime; set => _creationTime = value; } // tijd dat de ticket is aangemaakt
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public IncidentType IncidentType { get => _incidentType; set => _incidentType = value; }
        public Priority Priority { get => _priority; set => _priority = value; }
        public string Solution { get => _solution; set => _solution = value; } // solution of the ticket problem
        public bool PastDeadline { get { return (DateTime.Now > Deadline); } }
        public Status Status { get => _status; set => _status = value; }
    }
}
