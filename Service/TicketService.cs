using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TicketService
    {
        readonly TicketRepository ticketRepository;
        public TicketService(TicketRepository ticketRepository) 
        {
            this.ticketRepository = ticketRepository;
        }
        public IEnumerable<Ticket>? GetTickets()
        {
            return ticketRepository.getTickes();
        }
    }
}
