﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvent.Classes
{
    public class Events
    {
        public string EventID { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public byte[] Image { get; set; } // Storing image as byte array

        public decimal TicketPrice { get; set; }

        public Events(string eventID, string eventName, string description, DateTime eventDate, string location, byte[] image, decimal ticketPrice)
        {
            EventID = eventID;
            EventName = eventName;
            Description = description;
            EventDate = eventDate;
            Location = location;
            Image = image;
            TicketPrice = ticketPrice;
        }
    }
}
