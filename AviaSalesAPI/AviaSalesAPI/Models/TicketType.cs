using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class TicketType
    {
        public TicketType()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int IdTicketType { get; set; }
        public string Type { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
