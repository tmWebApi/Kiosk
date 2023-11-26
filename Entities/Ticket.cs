using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ticket
    {
        public int AvailablePlaces { get; set; }
        public bool IsClosed { get; set; }
        public string StartTime { get; set; }
    }
}
