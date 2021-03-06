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
    [Route("/flights")]
    public class FlightsController : Controller
    {
        private readonly IFlightsRepository flightsRepository;
        private readonly AppDbContext appDbContext;

        public FlightsController(IFlightsRepository flightsRepository , AppDbContext appDbContext)
        {
            this.flightsRepository = flightsRepository;
            this.appDbContext = appDbContext;
        }
        [HttpGet]
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
        [HttpGet]
        [Route("FlightDetails")]
        public IActionResult FlightDetails(int id)
        {
            var flightDetails = flightsRepository.getFlightDetails(id);

            return View(flightDetails);
        }
        [HttpPost][Route("BookFlight")]
        public IActionResult BookFlight(int flightId, int ordinaryTickets, int businessTickets)
        {
            if (!GlobalVariables.isLoggedIn)
            {
                return View("../userAccount/Login");
            }
            /*if (ordinaryTickets == 0 && businessTickets == 0) return ;*/
            var flight = flightsRepository.getFlightDetails(flightId);
            FlightBookModel fbm = new FlightBookModel()
            {
                Flight = flight,
                BusinessTickets = businessTickets,
                OrdinaryTickets = ordinaryTickets,
                TotalPrice = (flight.ORDINARYprice * ordinaryTickets) + ( businessTickets * flight.BUSINESSprice)
            };
            return View(fbm);
        }
        public IActionResult TicketsPayment()
        {
            return Redirect("~/Views/Home/Index.cshtml");
        }
    }
}
