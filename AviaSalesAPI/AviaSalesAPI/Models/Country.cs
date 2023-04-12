using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public int IdCountry { get; set; }
        public int PhoneCode { get; set; }
        public string CountryCode { get; set; } = null!;
        public string CountryName { get; set; } = null!;

        public virtual ICollection<City> Cities { get; set; }
    }
}
