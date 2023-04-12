using AviaSalesAPI.Contracts;
using AviaSalesAPI.Extensions;
using AviaSalesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MEGACONTROLLA : ControllerBase
    {
        private UshakovVKR_AviaSalesContext context;


        // <MEGACONTROLLA>

        public MEGACONTROLLA(UshakovVKR_AviaSalesContext context)
        {
            this.context = context;
        }

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> GetUsers([FromBody] LoginRequest loginRequest)
        {    
            var user = await context.Users
                .FirstOrDefaultAsync(user => user.Login == loginRequest.Login && user.Password == loginRequest.Password);

            if (user is null)
            {
                return BadRequest();
            } 

            return Ok(user.ToResponse());
        }

        [HttpPost("GetClients/{id}")]
        public async Task<IActionResult> GetClients(int id)
        {
            var user = await context.Users
                .FirstOrDefaultAsync(user => user.IdUser == id);

            if(user is null)
            {
                return NotFound();
            }

            var clients = user.Clients.ToList();

            if (user is null)
            {
                return BadRequest();
            }

            return Ok(user.ToResponse());
        }
        
        [HttpGet("GetTicket/{id}")]
        public async Task<IActionResult> GetTicket(int id)
        {
            var tickets = await context.Tickets.Where(ticket => ticket.IdTicket == id).ToListAsync();

            if (tickets is null)
            {
                return NotFound();
            }

            return Ok(tickets.Select(Ticket => Ticket.ToResponse()));
        }

        [HttpGet("GetFlightData/{id}")]
        public async Task<IActionResult> GetFlightData(int id)
        {
            var flight = await context.FlightData.FirstOrDefaultAsync(flight => flight.IdFlight == id);

            if (flight is null)
            {
                return NotFound();
            }

            return Ok(flight.ToResponse());
        }

        [HttpGet("GetCompany/{id}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            var company = await context.Companies.FirstOrDefaultAsync(company => company.IdCompany == id);

            if (company is null)
            {
                return NotFound();
            }

            return Ok(company.ToResponse());
        }

        [HttpGet("GetNotifications/{id}")]
        public async Task<IActionResult> GetNotifications(int id)
        {
            var notifications = await context.Notifications.Where(notifications => notifications.IdClient == id).ToListAsync();

            if (notifications is null)
            {
                return NotFound();
            }

            return Ok(notifications.Select(Notification => Notification.ToResponse()));
        }

        [HttpGet("GetNotificationById/{id}")]
        public async Task<IActionResult> GetNotificationById(int id)
        {
            var notification = await context.Notifications.FirstOrDefaultAsync(notification => notification.IdNotification == id);

            if (notification is null)
            {
                return NotFound();
            }

            return Ok(notification.ToResponse());
        }

        [HttpDelete("DeleteNotificationById/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {

            var notification = await context.Notifications.FirstOrDefaultAsync(notification => notification.IdNotification == id);

            if (notification is null)
            {
                return NotFound();
            }
            context.Remove(notification);
            var deleted = await context.SaveChangesAsync();

            return Ok(deleted);
        }

    }
}
