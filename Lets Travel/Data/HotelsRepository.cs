using Lets_Travel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Data
{
    public class HotelsRepository : IHotelsRepository
    {
        private readonly AppDbContext flightsDbContext;

        public HotelsRepository(AppDbContext flightsDbContext)
        {
            this.flightsDbContext = flightsDbContext;
        }
        public IEnumerable<Hotel> GetAllHotels()
        {
            IEnumerable<Hotel> hotels = flightsDbContext.Hotels.ToList();
            return hotels;
        }

        public IEnumerable<Hotel> GetHotelsByCity(GetHotels hotel)
        {
            IEnumerable<Hotel> hotels = flightsDbContext.Hotels.Where(x => x.City == hotel.City.ToLower());
            return hotels;
        }

        public Hotel GetHotelsById(int id)
        {
            var hotel = flightsDbContext.Hotels.FirstOrDefault(x => x.HotelId == id);
            return hotel;
        }
    }
}
