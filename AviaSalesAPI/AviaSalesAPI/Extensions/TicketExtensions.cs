using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSalesAPI.Contracts;
using AviaSalesAPI.Contracts.Tickets;
using AviaSalesAPI.Models;

namespace AviaSalesAPI.Extensions
{
    public static class TicketExtensions
    {
        public static TicketResponse ToResponse(this Ticket ticket)
        {
            return new TicketResponse
            {
                IdTicket = ticket.IdTicket,
                IdFlight = ticket.IdFlight,
                IdClient = ticket.IdClient,
                IdTicketType = ticket.IdTicketType,
                Price = ticket.Price,
                DateOfPurchase = ticket.DateOfPurchase,
                FlightDescription = ticket.FlightDescription,
                Seat = ticket.Seat
            };
        }
    }
}
