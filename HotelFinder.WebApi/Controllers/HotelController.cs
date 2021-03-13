using System.Collections.Generic;
using Bussiness.Abstract;
using Bussiness.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace HotelFinder.WebApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }


        /// <summary>
        /// Get All Hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var hotels = _hotelService.GetAllHotels();
            return Ok(hotels);
        }

        /// <summary>
        /// Get Hotels by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 
        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetHotelById(int id)
        {
            var hotel = _hotelService.GetHotelById(id);
            if (hotel != null)
            {
                return Ok(hotel);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("[action]/{name}")]
        public IActionResult GetHotelByName(string name)
        {
            var hotel = _hotelService.GetHotelByName(name);
            if (hotel != null)
            {
                return Ok(hotel);
            }

            return NotFound();
        }


        /// <summary>
        /// Create a Hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public IActionResult Create([FromBody] Hotel hotel)
        {
            var createdHotel = _hotelService.CreateHotel(hotel);
            return CreatedAtAction("Get", new {id = createdHotel.Id}, createdHotel);
        }

        /// <summary>
        /// Update the Hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public IActionResult Update([FromBody] Hotel hotel)
        {
            var updatedHotel = _hotelService.UpdateHotel(hotel);
            if (_hotelService.GetHotelById(hotel.Id) != null)
            {
                return Ok(updatedHotel);
            }

            return NotFound();
        }


        /// <summary>
        /// Delete the Hotel
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("[action]")]
        public IActionResult Delete(int id)
        {
            if (_hotelService.GetHotelById(id) != null)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}