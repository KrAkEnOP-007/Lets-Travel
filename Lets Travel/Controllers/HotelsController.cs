using Lets_Travel.Data;
using Lets_Travel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IHotelsRepository repository;

        public HotelsController(IHotelsRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Hotels()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetHotels(GetHotels getHotels)
        {
            if (ModelState.IsValid)
            {
                var hotels= repository.GetAllHotels();
                return View();
            }
            return View(null);
        }
        public IActionResult HotelDetails(int id)
        {
            return View();
        }
        public IActionResult BookHotel()
        {
            return View();
        }
    }
}
