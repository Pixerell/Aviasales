using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class Notification
    {
        public int IdNotification { get; set; }
        public int IdClient { get; set; }
        public DateTime? DateOfNotifying { get; set; }
        public decimal Price { get; set; }
        public string? AdditionalInformation { get; set; }
        public int IdPriceCheck { get; set; }
        public int HotelId { get; set; }
        public bool? Status { get; set; }
        public DateTime? DateSet { get; set; }

        public virtual Client IdClientNavigation { get; set; } = null!;
        public virtual Pricecheck IdPriceCheckNavigation { get; set; } = null!;
    }
}
