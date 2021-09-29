using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using DAL;
using Model;
namespace Logic
{
    public class Ticket_Logic
    {
        Ticket_DAL _tickets = new Ticket_DAL();

        // insert a new ticket in the database
        public void InsertTicket(Ticket ticket)
        {
            try
            {
                _tickets.InsertTicket(ticket);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // retreive all open en close tickets
        public List<Ticket> RetrieveAllTickets()
        {
            try
            {
                return _tickets.RetrieveTickets();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
            // return list of the filter
        public List<Ticket> FilterList(String keyWord)
        {
            try
            {
               return _tickets.FilterTickets(keyWord);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // order tickets by priority
        public List<Ticket> OrderTickets(string OrderPriority)
        {
            try
            {
                return _tickets.OrderTickets(OrderPriority);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // update the ticket after making changes
        public void UpdateTicket(Ticket ticket)
        {
            try
            {
                _tickets.UpdateTicket(ticket);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // Add the ticket to the list of the user
        public void UpdateTicketListOfUser(User userTicket)
        {
            try
            {
                _tickets.FillTicketListUser(userTicket);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteTicket(Ticket ticket)
        {
            try
            {
                _tickets.DeleteTicket(ticket);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
