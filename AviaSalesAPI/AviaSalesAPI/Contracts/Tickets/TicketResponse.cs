using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesAPI.Contracts.Tickets
{
    public class TicketResponse
    {
        public int IdTicket { get; set; }
        public int IdClient { get; set; }
        public int Seat { get; set; }
        public string? FlightDescription { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public decimal? Price { get; set; }
        public int IdTicketType { get; set; }
        public int IdFlight { get; set; }

    }
}
