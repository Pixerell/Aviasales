using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesAPI.Contracts
{
    public class UserResponse
    {
        public int IdUser { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int IdRole { get; set; }
    }
}
