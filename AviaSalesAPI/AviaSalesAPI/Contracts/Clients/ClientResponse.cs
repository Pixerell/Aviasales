using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesAPI.Contracts.Clients
{
    public class ClientResponse
    {
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
    }
}
