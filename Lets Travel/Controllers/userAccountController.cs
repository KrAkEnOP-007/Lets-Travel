using Lets_Travel.Api_DTO;
using Lets_Travel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Lets_Travel.Controllers
{
    public class userAccountController : Controller
    {
        static HttpClient client = new HttpClient();
        public userAccountController()
        {
            client.BaseAddress = new Uri("https://localhost/api/account");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public IActionResult Login()
        {
            return View();
        }
        // when user clicks login button it will check all the conditions and teh execute the method
        // this method calls api with username and password and api will return a appDTO with appropriate information 
        // Then user will be redirected to the home page of Lets Travel wbsite
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel ul)
        {
            if (ModelState.IsValid)
            {
                //GlobalVariables.SessionUserId = ul.Email;
                // Creating session for the user  
                HttpContext.Session.SetString("UserId", GlobalVariables.SessionUserId);
                
                //Login lgn = new Login() { UserId = ul.Email , Password = ul.Password };
                // ViewBag.user = ul.Email;
                // @Context.Session.GetString("username")
                // HttpContext.Session.SetString("username", username);
                //ViewBag.user =  HttpContext.Session.GetString("UserId");
                
                return View("~/Views/Home/Index.cshtml");
               // HttpResponseMessage response = await client.GetAsync("");
            }
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUp ul)
        {
            if (ModelState.IsValid)
            {
                Register dto = new Register() { Email_Id = ul.Email, FirstName = ul.FirstName , LastName = ul.LastName , 
                                     Mobile_No = ul.Mobile_No , Password = ul.Password , UserNo = 0 , User_Id = ul.UserId};
                HttpResponseMessage response = await client.PostAsJsonAsync(
               "", dto);
            }
            return View();
        }
    }
}
