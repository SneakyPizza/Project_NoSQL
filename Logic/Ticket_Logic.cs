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
        private static Ticket_Logic _login_logic;
        public static Ticket_Logic Instance
        {
            get
            {
                if (_login_logic == null) { _login_logic = new Ticket_Logic(); }
                return _login_logic;
            }
        }
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
                _tickets.TestAggregation();
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
                Priority Ticketpriority = (Priority)Enum.Parse(typeof(Priority), OrderPriority);
                return _tickets.OrderTickets(Ticketpriority);
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
        public List<Ticket> TicketsOFuser(User user)
        {
            try
            {
                return _tickets.ListTicketsOFUser(user);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public string GetCreatedByName(Ticket TicketID)
        {
            try
            {
                return _tickets.GetCreatedByName(TicketID.TicketCreatedBy);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
