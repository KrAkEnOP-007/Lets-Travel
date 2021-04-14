using Lets_Travel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Controllers
{
    public class userAccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel userlogin)
        {
            if (ModelState.IsValid)
            {
                return View("../home/index");
            }
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUp getUser)
        {
            if (ModelState.IsValid)
            {
                return View("Login");
            }
            return View();
        }
    }
}
