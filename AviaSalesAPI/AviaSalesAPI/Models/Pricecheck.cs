using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class Pricecheck
    {
        public Pricecheck()
        {
            Notifications = new HashSet<Notification>();
        }

        public int IdPriceCheck { get; set; }
        public string PriceAction { get; set; } = null!;

        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
