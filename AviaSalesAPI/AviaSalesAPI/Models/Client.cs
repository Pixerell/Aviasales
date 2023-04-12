using System;
using System.Collections.Generic;

namespace AviaSalesAPI.Models
{
    public partial class Client
    {
        public Client()
        {
            Notifications = new HashSet<Notification>();
            Tickets = new HashSet<Ticket>();
        }

        public int IdClient { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string GenderCode { get; set; } = null!;
        public int PassportSeries { get; set; }
        public int PassportNumber { get; set; }
        public int IntPassportType { get; set; }
        public int? IdUser { get; set; }

        public virtual Gender GenderCodeNavigation { get; set; } = null!;
        public virtual User? IdUserNavigation { get; set; }
        public virtual PassportType IntPassportTypeNavigation { get; set; } = null!;
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
