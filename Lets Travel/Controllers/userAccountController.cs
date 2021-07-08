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
using System.Web;

namespace Lets_Travel.Controllers
{
    public class userAccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        // when user clicks login button it will check all the conditions and teh execute the method
        // this method calls api with username and password and api will return a appDTO with appropriate information 
        // Then user will be redirected to the home page of Lets Travel wbsite
        [HttpPost]
        public IActionResult Login(LoginModel ul)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.Clear();
                try
                {
                    HttpResponseMessage response = GlobalVariables.client.GetAsync("/Login?id=" + ul.Email + "&pass=" + ul.Password).Result;
                    AppDTO result = response.Content.ReadAsAsync<AppDTO>().Result;


                    if (result.IsLoggedIn == false)
                    {
                        ViewBag.LoginError = result.ErrotMsg;
                        return View();
                    }

                    HttpContext.Session.SetString("UserId", result.User_Id);
                    ViewBag.successMsg = "LoggedIn Successfully";
                    GlobalVariables.isLoggedIn = true;
                    GlobalVariables.SessionUserId = result.User_Id;
                    GlobalVariables._user = result;
                }
                catch(Exception ex)
                {
                    ViewBag.LoginError = "There Was An Error Try Again!!!";
                    return View();
                }




                //Login lgn = new Login() { UserId = ul.Email , Password = ul.Password };
                // ViewBag.user = ul.Email;
                // @Context.Session.GetString("username")
                // HttpContext.Session.SetString("username", username);
                //ViewBag.user = HttpContext.Session.GetString("UserId");
                //return RedirectToPage("index");
                return View("~/Views/Home/Index.cshtml");


            }
            return View();
        }
        [HttpPost]
        public IActionResult LogOut()
        {
            GlobalVariables.isLoggedIn = false;
            GlobalVariables.SessionUserId = null;
            GlobalVariables._user = null;
            HttpContext.Session.Clear();

            return View("~/Views/Home/Index.cshtml");
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUp ul)
        {
            if (ModelState.IsValid)
            {
                Register dto = new()
                {
                    Email_Id = ul.Email,
                    FirstName = ul.FirstName,
                    LastName = ul.LastName,
                    Mobile_No = ul.Mobile_No ,
                    Password = ul.Password ,
                    UserNo = 0 ,
                    User_Id = ul.UserId
                };
               
                    HttpResponseMessage response = GlobalVariables.client.PostAsJsonAsync("/Register", dto).Result;
                    AppDTO result = response.Content.ReadAsAsync<AppDTO>().Result;
                    if (result.IsLoggedIn == false)
                    {
                        TempData["SuccessMsg"] = result.ErrotMsg;
                        return View(TempData);
                    }
                
                HttpContext.Session.SetString("UserId", result.User_Id);
                
                GlobalVariables.isLoggedIn = true;
                
                GlobalVariables.SessionUserId = result.User_Id;
                
                GlobalVariables._user = result;

                TempData["SuccessMsg"] = "Registered Successfully";


                return View("~/Views/Home/Index.cshtml");
                
                
                   
                
            }
            return View();
        }
    }
}
