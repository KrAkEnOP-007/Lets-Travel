using Lets_Travel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Data
{
    public class FlightsRepository : IFlightsRepository
    {
        private readonly AppDbContext flightsDbContext;

        public FlightsRepository(AppDbContext flightsDbContext)
        {
            this.flightsDbContext = flightsDbContext;
        }
        public IEnumerable<Flights> GetAllFlights()
        {
            IEnumerable<Flights> flights = flightsDbContext.Flights.ToList<Flights>();
            return flights;
        }

        public Flights getFlightDetails(int id)
        {
            var flight = flightsDbContext.Flights.FirstOrDefault(x=> x.FlightID == id);
            return flight;
        }

        public IEnumerable<Flights> getSomeFlights(string FlightFrom, string FlightTo, string date)
        {
            IEnumerable<Flights> flights = flightsDbContext.Flights
                .Where(x => x.FlightFrom ==FlightFrom && x.FlightTo ==FlightTo && x.Date ==date).ToList<Flights>();
            return flights;
        }
    }
}
