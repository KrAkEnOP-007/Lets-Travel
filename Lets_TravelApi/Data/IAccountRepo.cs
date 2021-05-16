using Lets_TravelApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_TravelApi.Data
{
    public interface IAccountRepo
    {
        public AppDTO LoginUser(Login login);
        public AppDTO Register(Register register);


    }
}
