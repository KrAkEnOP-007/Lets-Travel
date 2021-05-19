using Lets_TravelApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_TravelApi.Data
{
    public class AccountRepo : IAccountRepo
    {
        private readonly AppDbContext db;

        public AccountRepo(AppDbContext db)
        {
            this.db = db;
        }
        public AppDTO LoginUser(Login model)
        {
            var response = new AppDTO();
            var login = db.Users.FirstOrDefault(x => x.Email_Id == model.UserId && x.Password == model.Password);
            if (login != null)
            {
                response = new AppDTO()
                {
                    IsLoggedIn = true,
                    User_Id = login.User_Id,
                    ErrotMsg = "none"
                };
            }
            else
            {
                response = new AppDTO()
                {
                    IsLoggedIn = false,
                    User_Id = "none",
                    ErrotMsg = "Email Id or password is wrong"
                };
            }
            return response;

        }

        public AppDTO Register(Register register)
        {
            string err = "";
            var temp = db.Users.FirstOrDefault(x => x.User_Id == register.User_Id);

            if (temp != null) { 
                err += "user name already exists !!!";
                return new AppDTO() { ErrotMsg = err, IsLoggedIn = false, User_Id = "" }; 
            }

            temp = db.Users.FirstOrDefault(x => x.Email_Id == register.Email_Id);
            if (temp != null) {
                err += "   email is already in use !!!"; 
                return new AppDTO() { ErrotMsg = err, IsLoggedIn = false, User_Id = "" }; 
            }
            
            temp = db.Users.FirstOrDefault(x => x.Mobile_No == register.Mobile_No);
            if (temp != null) {
                err += "   mobile no is already in use !!!"; 
                return new AppDTO() { ErrotMsg = err, IsLoggedIn = false, User_Id = "" };
            }


            db.Users.Add(register);
            db.SaveChanges();
            return new AppDTO()
            {
                IsLoggedIn = true , User_Id = register.User_Id , ErrotMsg = "no error"
            };
        }

        public AppDTO RegisterUser(Register model)
        {
            var response = new AppDTO();

            db.Users.Add(model);

            return response;
        }
    }
}
