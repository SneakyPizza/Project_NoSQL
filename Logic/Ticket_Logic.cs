﻿using System;
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
        public List<Ticket> OrderTickets(String OrderPriority)
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
    }
}
