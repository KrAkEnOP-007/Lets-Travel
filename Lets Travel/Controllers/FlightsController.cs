using Lets_Travel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Controllers
{
    public class FlightsController : Controller
    {
        public IActionResult Flights()
        {
            return View();
        }
       
        
        [HttpPost]
        public IActionResult Flights(GetFlights Flightmodel)
        {
            if (ModelState.IsValid)
            {
                return View("../home/index");
            }
            return View();
        }
    }
}
