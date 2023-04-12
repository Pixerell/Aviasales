using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class FlightDatum
    {
        public FlightDatum()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int IdFlight { get; set; }
        public int IdDestination { get; set; }
        public bool IsCanceled { get; set; }
        public int IdCompany { get; set; }
        public int FlightTimeDurationInMinutes { get; set; }
        public DateTime DateOfFlight { get; set; }
        public string? PlaneNumber { get; set; }
        public decimal? EconomPrice { get; set; }
        public decimal? BuisinessPrice { get; set; }
        public int IdDestinationFrom { get; set; }
        public DateTime? DateFlightEnd { get; set; }

        public virtual Company IdCompanyNavigation { get; set; } = null!;
        public virtual Destination IdDestinationFromNavigation { get; set; } = null!;
        public virtual Destination IdDestinationNavigation { get; set; } = null!;
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
