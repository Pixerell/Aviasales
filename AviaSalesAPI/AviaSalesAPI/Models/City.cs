using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class City
    {
        public City()
        {
            Destinations = new HashSet<Destination>();
        }

        public int IdCity { get; set; }
        public string CityName { get; set; } = null!;
        public int IdCountry { get; set; }
        public string? Image { get; set; }

        public virtual Country IdCountryNavigation { get; set; } = null!;
        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
