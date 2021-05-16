using Lets_TravelApi.Data;
using Lets_TravelApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_TravelApi.Controllers
{

    [ApiController]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly IAccountRepo loginRepo;

        public AccountController(IAccountRepo loginRepo)
        {
            this.loginRepo = loginRepo;
        }
        // GET: AccountController
        [HttpGet]
        [Route("/Login")]
        public ActionResult<AppDTO> Login(string id , string pass)
        {
            Login model = new Login()
            {
                UserId = id,
                Password = pass
            };
            var res = loginRepo.LoginUser(model);
            return Ok(res);
        }
        [HttpPost]
        [Route("/Register")]
        public ActionResult<AppDTO> register(Register register)
        {
            var res = loginRepo.Register(register);
            return Ok(res);
        }
       
        
    }
}
