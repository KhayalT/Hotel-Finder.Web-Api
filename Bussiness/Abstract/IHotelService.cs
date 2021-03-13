using System.Collections.Generic;
using Entities;

namespace Bussiness.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotelById(int id);
        Hotel GetHotelByName(string name);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);
    }
}