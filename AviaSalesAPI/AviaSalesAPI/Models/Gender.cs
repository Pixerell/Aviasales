using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Clients = new HashSet<Client>();
        }

        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Client> Clients { get; set; }
    }
}
