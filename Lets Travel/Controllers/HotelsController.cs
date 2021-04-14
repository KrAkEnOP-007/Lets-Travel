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
        public IActionResult Hotels()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Hotels(GetHotels getHotels)
        {
            if (ModelState.IsValid)
            {
                return View("../home/index");
            }
            return View();
        }
    }
}
