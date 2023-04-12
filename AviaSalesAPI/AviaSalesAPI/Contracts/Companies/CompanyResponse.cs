using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesAPI.Contracts.Companies
{
    public class CompanyResponse
    {
        public int IdCompany { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Website { get; set; }
        public string Designator { get; set; } = null!;
        public string? Image { get; set; }

    }
}
