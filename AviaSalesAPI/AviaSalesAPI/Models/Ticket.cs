using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class Ticket
    {
        public int IdTicket { get; set; }
        public int IdClient { get; set; }
        public int Seat { get; set; }
        public string? FlightDescription { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public decimal? Price { get; set; }
        public int IdTicketType { get; set; }
        public int IdFlight { get; set; }

        public virtual Client IdClientNavigation { get; set; } = null!;
        public virtual FlightDatum IdFlightNavigation { get; set; } = null!;
        public virtual TicketType IdTicketTypeNavigation { get; set; } = null!;
    }
}
