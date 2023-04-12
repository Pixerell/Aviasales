using AviaSalesAPI.Contracts;
using AviaSalesAPI.Contracts.Flights;
using AviaSalesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesAPI.Extensions
{
    public static class FlightExtensions
    {
        public static FlightResponse ToResponse(this FlightDatum flight)
        {
            return new FlightResponse
            {
                IdCompany = flight.IdCompany,
                IdFlight = flight.IdFlight,
                IdDestination = flight.IdDestination,
                IdDestinationFrom = flight.IdDestinationFrom,
                FlightTimeDurationInMinutes = flight.FlightTimeDurationInMinutes,
                DateOfFlight = flight.DateOfFlight,
                EconomPrice = flight.EconomPrice,
                BuisinessPrice = flight.BuisinessPrice,
                PlaneNumber = flight.PlaneNumber,
                IsCanceled = flight.IsCanceled
            };
        }
    }
}
