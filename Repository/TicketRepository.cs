using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TicketRepository
    {
        string jsonFilePath = "../Repository/data.json";


        public IEnumerable<Ticket>? getTickes()
        {
            string jsonData = File.ReadAllText(jsonFilePath);

            IEnumerable<Ticket>? tickets = JsonConvert.DeserializeObject<IEnumerable<Ticket>>(jsonData);
            return tickets;
        }
    }
}
