using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AviaSalesAPI.Models
{
    public partial class User
    {
        public User()
        {
            Clients = new HashSet<Client>();
        }

        public int IdUser { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int IdRole { get; set; }

        [JsonIgnore]
        public virtual Role IdRoleNavigation { get; set; } = null!;

        [JsonIgnore]
        public virtual ICollection<Client> Clients { get; set; }
    }
}
