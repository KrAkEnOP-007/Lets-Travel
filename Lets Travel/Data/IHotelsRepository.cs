using Lets_Travel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Data
{
    public interface IHotelsRepository
    {
        IEnumerable<Hotel> GetAllHotels();
        IEnumerable<Hotel> GetCityHotels(GetHotels hotel);

    }
}
