using Lets_Travel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Data
{
    public interface IFlightsRepository
    {
        IEnumerable<Flights> GetAllFlights();
        IEnumerable<Flights> getSomeFlights(string FlightFrom, string FlightTo , string date);

    }
}
