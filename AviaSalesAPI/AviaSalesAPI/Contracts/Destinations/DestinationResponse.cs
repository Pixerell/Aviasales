using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesAPI.Contracts.Destinations
{
    public class DestinationResponse
    {
        public int IdDestination { get; set; }
        public int IdCity { get; set; }
        public string Aeroport { get; set; } = null!;
        public decimal? TimeZone { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Long { get; set; }
        public int Visits { get; set; }
    }
}
