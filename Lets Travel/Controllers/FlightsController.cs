using Lets_Travel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lets_Travel.Data;
using Microsoft.AspNetCore.Http;

namespace Lets_Travel.Controllers
{
    public class FlightsController : Controller
    {
        private readonly IFlightsRepository flightsRepository;
        private readonly AppDbContext appDbContext;

        public FlightsController(IFlightsRepository flightsRepository , AppDbContext appDbContext)
        {
            this.flightsRepository = flightsRepository;
            this.appDbContext = appDbContext;
        }
        public IActionResult Flights()
        {
            var cities = appDbContext.City.ToList();
            ViewBag.cities = cities;
            
            
            return View();
        }
       
        
        [HttpPost]
        public IActionResult GetFlights(GetFlights Flightmodel)
        {
            if (ModelState.IsValid)
            {
                var AllFlights =flightsRepository.getSomeFlights
                    (Flightmodel.FlightFrom.ToLower() , Flightmodel.FlightTo.ToLower() ,Flightmodel.OnDate.ToString());
                return View(AllFlights);
            }

            return View(null);
        }
        public IActionResult FlightDetails()
        {
            return View();
        }
    }
}
