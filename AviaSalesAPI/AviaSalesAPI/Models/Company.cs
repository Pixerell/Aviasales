using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class Company
    {
        public Company()
        {
            FlightData = new HashSet<FlightDatum>();
        }

        public int IdCompany { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Website { get; set; }
        public string Designator { get; set; } = null!;
        public string? Image { get; set; }

        public virtual ICollection<FlightDatum> FlightData { get; set; }
    }
}
