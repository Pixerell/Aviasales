using System;
using AviaSalesAPI.Contracts;
using AviaSalesAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSalesAPI.Contracts.Companies;

namespace AviaSalesAPI.Extensions
{
    public static class CompanyExtensions
    {
        public static CompanyResponse ToResponse(this Company company)
        {
            return new CompanyResponse
            {
                IdCompany = company.IdCompany,
                Title = company.Title,
                Description = company.Description,
                Website = company.Website,
                Designator = company.Designator,
                Image = company.Image

            };
        }
    }
}
