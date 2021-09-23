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
        public void InsertTicket(Ticket ticket) // insert ticket in de database
        {
            GetDatabaseTickets().InsertOne(ticket);
        }
        // retrieve all tickets that or open or that are pending
        public List<Ticket> RetrieveTickets()
        {
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("Status", Status.Open) | Builders<Ticket>.Filter.Eq("Status", Status.Pending);
            List<Ticket> Tickets = GetDatabaseTickets().Find(filter).ToList();
            return Tickets;
        }
        // take all tickets with specific keyword
        public List<Ticket> FilterTickets(String keyword)
        {
            IList<FilterDefinition<Ticket>> filtersList = new List<FilterDefinition<Ticket>>();
            filtersList.Add(new BsonDocument("IncidentType", keyword));
            FilterDefinitionBuilder<Ticket> builder = Builders<Ticket>.Filter;
            List<Ticket> Tickets = GetDatabaseTickets().Find(builder.And(filtersList)).ToList();
            return Tickets;
        }
        // sort the tickets by priority
        public List<Ticket> OrderTickets(String OrderPriority)
        {
            List<Ticket> tickets = RetrieveTickets();
            tickets.Sort((p, q) => p.Priority.CompareTo(q.Priority));
            tickets.Sort((p, q) => q.Priority.CompareTo(OrderPriority)); // the chosen priority is the first in the list
            return tickets;
        }
        // update the ticket after changing values
        public void UpdateTicket(Ticket ticket)
        {
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq(x => x.id, ticket.id);
            UpdateDefinition<Ticket> update = Builders<Ticket>.Update.Set("Status", ticket.Status)
                .Set("Solution", ticket.Solution)
                .Set("Priority", ticket.Priority);
            GetDatabaseTickets().UpdateOne(filter, update);
        }
    }
}
