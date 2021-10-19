﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class Ticket_DAL : Base
    {
        // return the database tickets
        private IMongoCollection<Ticket> GetDatabaseTickets()
        {
            return GetDatabase().GetCollection<Ticket>("Tickets");
        }
        // insert ticket in de database
        public void InsertTicket(Ticket ticket)
        {
            GetDatabaseTickets().InsertOne(ticket);
        }
        // retrieve all tickets that or open or that are pending
        public List<Ticket> RetrieveTickets()
        {
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("Status", Status.OnHold)
                | Builders<Ticket>.Filter.Eq("Status", Status.Processing)
                | Builders<Ticket>.Filter.Eq("Status", Status.Registered);
            List<Ticket> Tickets = GetDatabaseTickets().Find(filter).ToList();
            return Tickets;
        }
        // take all tickets with specific keyword
        public List<Ticket> FilterTickets(string keyword)
        {
            

            IList<FilterDefinition<Ticket>> filtersList = new List<FilterDefinition<Ticket>>();
            int keywordint = 0;
            if (keyword == "hardware")
            {
                keywordint = 0;
            }
            else if (keyword == "software")
            {
                keywordint = 1;
            }
            else if (keyword == "service")
            {
                keywordint = 2;
            }
            keyword = Enum.GetName(typeof(IncidentType), keywordint);
            
            filtersList.Add(new BsonDocument("IncidentType", keywordint));
            FilterDefinitionBuilder<Ticket> builder = Builders<Ticket>.Filter;
            List<Ticket> Tickets = GetDatabaseTickets().Find(builder.And(filtersList)).ToList();
            return Tickets;
        }
        // sort the tickets by priority
        public List<Ticket> OrderTickets(Priority OrderPriority)
        {
            List<Ticket> tickets = RetrieveTickets();
            tickets.Sort((p, q) => p.Priority.CompareTo(q.Priority));
            tickets.Sort((p, q) => q.Priority.CompareTo(OrderPriority));
            return tickets;
        }
        // update the ticket after changing values
        public void UpdateTicket(Ticket ticket)
        {
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq(x => x.Id, ticket.Id);
            UpdateDefinition<Ticket> update = Builders<Ticket>.Update.Set("Status", ticket.Status)
                .Set("Solution", ticket.Solution)
                .Set("Priority", ticket.Priority)
                .Set("Deadline", ticket.Deadline);
            GetDatabaseTickets().UpdateMany(filter, update);
        }
        // get the list of tickets of the logged in user
        public List<Ticket> ListTicketsOFUser(User user)
        {
            FilterDefinition<Ticket> FilterUser = Builders<Ticket>.Filter.Eq("UserID", user.Id);
            List<Ticket> TicketsOfUser = GetDatabaseTickets().Find(FilterUser).ToList();
            return TicketsOfUser;
        }
        public void TestAggregation()
        {
            var collection = GetDatabaseTickets();
            var docs = collection.Aggregate().Lookup("Users", "UserID", "_id", "asTicket").ToList();
        }
        public void DeleteTicket(Ticket ticket)
        {
            FilterDefinition<Ticket> deleteFilter = Builders<Ticket>.Filter.Eq("_id", ticket.Id);
            GetDatabaseTickets().DeleteOne(deleteFilter);
        }
        // get the full name of the user that handeld the ticket
        public string GetCreatedByName(ObjectId ticketid)
        {
            IMongoCollection<User> collection = GetDatabase().GetCollection<User>("Users");
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("_id", ticketid);
            User user = collection.Find(filter).First();
            return user.Fullname;
        }
        //public User GetUser(Ticket ticketID)
        ////{
        ////    var collection = GetDatabaseTickets();
        ////    var docs = collection.Aggregate().Lookup("Users", "UserID", "_id", "asTicket").ToList();
        ////    // var collection = GetDatabase().GetCollection<User>("Users");
        ////    // var filter = Builders<BsonDocument>.Filter.Eq("_id", ticketID.UserID);
        ////    var filter = Builders<BsonDocument>.Filter.Where(x => x.Equals(ticketID));
        ////    var ss = docs.Find(new Predicate<BsonDocument>(filter)).First();
           
        ////   // var filter2 = Builders<User>.Filter.Eq("UserID", ticketID.TicketCreatedBy);
        //    return ((User)collection.Find(filter).FirstOrDefault());
        }
    }

