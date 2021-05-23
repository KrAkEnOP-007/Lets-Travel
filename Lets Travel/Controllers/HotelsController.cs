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
                var hotels= repository.GetHotelsByCity(getHotels);
                return View(hotels);
            }
            return View(null);
        }
        [HttpGet]
        public IActionResult BookHotel(int id)
        {
            var hotel = repository.GetHotelsById(id);
            return View(hotel);
        }
        [HttpPost]
        public IActionResult BookHotel(int rooms , int singleBed , int DoubleBed)
        {
            return View();
        }
    }
}
