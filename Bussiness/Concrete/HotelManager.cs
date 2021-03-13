using System.Collections.Generic;
using Bussiness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;

namespace Bussiness.Concrete
{
    public class HotelManager:IHotelService
    {
        private IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
            return _hotelRepository.GetHotelById(id);
        }

        public Hotel GetHotelByName(string name)
        {
            return _hotelRepository.GetHotelByName(name);
        }

        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }
    }
}