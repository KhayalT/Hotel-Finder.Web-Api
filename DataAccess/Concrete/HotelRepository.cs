using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public List<Hotel> GetAllHotels()
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.ToList();
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.Find(id);
            }
        }

        public Hotel GetHotelByName(string name)
        {
            using (var hotelDbContext=new HotelDbContext())
            {
                return hotelDbContext.Hotels.FirstOrDefault(h=>h.Name.ToLower()==name.ToLower());
            }
        }

        public Hotel CreateHotel(Hotel hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Add(hotel);
                hotelDbContext.SaveChanges();
                return hotel;
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (var context = new HotelDbContext())
            {
                context.Update(hotel);
                return hotel;
            }
        }

        public void DeleteHotel(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                var hotel = GetHotelById(id);
                hotelDbContext.Remove(hotel);
                hotelDbContext.SaveChanges();
            }
        }
    }
}