using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesAPI.Contracts.Notifications
{
    public class NotificationResponse
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

    }
}
