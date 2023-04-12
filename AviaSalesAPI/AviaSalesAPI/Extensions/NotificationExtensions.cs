using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSalesAPI.Contracts.Notifications;
using AviaSalesAPI.Models;

namespace AviaSalesAPI.Extensions
{
    public static class NotificationExtensions
    {
        public static NotificationResponse ToResponse(this Notification notification)
        {
            return new NotificationResponse
            {
                IdNotification = notification.IdNotification,
                IdClient = notification.IdClient,
                IdPriceCheck = notification.IdPriceCheck,
                HotelId = notification.HotelId,
                DateSet = notification.DateSet,
                DateOfNotifying = notification.DateOfNotifying,
                Status = notification.Status,
                Price = notification.Price,
                AdditionalInformation = notification.AdditionalInformation
            };
        }
    }
}
