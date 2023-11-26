using Entities;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kiosk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        readonly TicketService ticketService;
        public TicketController(TicketService ticketService)
        {
            this.ticketService = ticketService;
        }
        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<Ticket>? Get()
        {
            return ticketService.GetTickets();
        }

    }
}
