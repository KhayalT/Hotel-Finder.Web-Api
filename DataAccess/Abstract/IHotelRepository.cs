using System.Collections.Generic;
using Entities;

namespace DataAccess.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotelById(int id);
        Hotel GetHotelByName(string name);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);
    }
}