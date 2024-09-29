using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvent.Classes
{
    public class Bookings
    {
        public int Id { get; set; }
        public string EventID { get; set; }

        public string ParticipantID { get; set; }

        public int NoOfParticipants { get; set; }

        public decimal Total { get; set; }

        public Bookings(string eventID, string participantID, int participants, decimal total)
        {
            EventID = eventID;
            ParticipantID = participantID;
            NoOfParticipants = participants;
            Total = total;
        }
    }
}
