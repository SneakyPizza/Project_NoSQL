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
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("Open", Open.Yes);
            List<Ticket> Tickets = GetDatabaseTickets().Find(filter).ToList();
            return Tickets;
        }
        // take all tickets with specific keyword
        public List<Ticket> FilterTickets(string keyword)
        {
            IList<FilterDefinition<Ticket>> filtersList = new List<FilterDefinition<Ticket>>();
            filtersList.Add(new BsonDocument("IncidentType", keyword));
            FilterDefinitionBuilder<Ticket> builder = Builders<Ticket>.Filter;
            List<Ticket> Tickets = GetDatabaseTickets().Find(builder.And(filtersList)).ToList();
            return Tickets;
        }
        // sort the tickets by priority
        public List<Ticket> OrderTickets(string OrderPriority)
        {
            List<Ticket> tickets = RetrieveTickets();
            tickets.Sort((p, q) => p.Priority.CompareTo(q.Priority));
            tickets.Sort((p, q) => q.Priority.CompareTo(OrderPriority)); // the chosen priority is the first in the list
            return tickets;
        }
        // update the ticket after changing values
        public void UpdateTicket(Ticket ticket)
        {
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq(x => x.Id, ticket.Id);
            UpdateDefinition<Ticket> update = Builders<Ticket>.Update.Set("Status", ticket.Status)
                .Set("Solution", ticket.Solution)
                .Set("Priority", ticket.Priority);
            GetDatabaseTickets().UpdateOne(filter, update);
        }
        // updates the list of tickets of the user after making a ticket
        public void FillTicketListUser(User user)
        {
            FilterDefinition<Ticket> FilterUser = Builders<Ticket>.Filter.Eq("UserID", user.Id);
            List<Ticket> TicketsOfUser = GetDatabaseTickets().Find(FilterUser).ToList();
            FilterDefinition<User> FilterTicket = Builders<User>.Filter.Eq(x => x.Id, user.Id);

            foreach (Ticket ticket in TicketsOfUser)
            {
                UpdateDefinition<User> update = Builders<User>.Update.AddToSet("Tickets", ticket.Id);
                GetDatabase().GetCollection<User>("Users").UpdateOne(FilterTicket, update);
            }
        }
        public List<Ticket> ListTicketsOFUser(User user)
        {
            FilterDefinition<Ticket> FilterUser = Builders<Ticket>.Filter.Eq("UserID", user.Id);
            List<Ticket> TicketsOfUser = GetDatabaseTickets().Find(FilterUser).ToList();
            return TicketsOfUser;
        }
        public void DeleteTicket(Ticket ticket)
        {
            FilterDefinition<Ticket> deleteFilter = Builders<Ticket>.Filter.Eq("_id", ticket.Id);
            GetDatabaseTickets().DeleteOne(deleteFilter);
        }
    }
}
