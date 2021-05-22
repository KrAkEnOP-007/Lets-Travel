using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Models
{
    public class FlightBookModel
    {
        public Flights Flight { get; set; }
        public int OrdinaryTickets { get; set; }
        public int BusinessTickets { get; set; }
        public int TotalPrice { get; set; }
    }
}
