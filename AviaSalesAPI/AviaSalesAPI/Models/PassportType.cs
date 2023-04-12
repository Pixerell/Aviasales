using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class PassportType
    {
        public PassportType()
        {
            Clients = new HashSet<Client>();
        }

        public int IdPassportType { get; set; }
        public string? PassportType1 { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
