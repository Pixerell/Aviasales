using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class Destination
    {
        public Destination()
        {
            FlightDatumIdDestinationFromNavigations = new HashSet<FlightDatum>();
            FlightDatumIdDestinationNavigations = new HashSet<FlightDatum>();
        }

        public int IdDestination { get; set; }
        public int IdCity { get; set; }
        public string Aeroport { get; set; } = null!;
        public decimal? TimeZone { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Long { get; set; }
        public int Visits { get; set; }

        public virtual City IdCityNavigation { get; set; } = null!;
        public virtual ICollection<FlightDatum> FlightDatumIdDestinationFromNavigations { get; set; }
        public virtual ICollection<FlightDatum> FlightDatumIdDestinationNavigations { get; set; }
    }
}
