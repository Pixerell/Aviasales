using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesAPI.Contracts.Flights
{
    public class FlightResponse
    {
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

    }
}
