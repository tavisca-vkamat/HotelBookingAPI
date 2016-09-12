using System.Collections.Generic;

namespace HotelBooking.hotelService
{
    public class HotelStatus
    {
        public List<Hotel> hotels { get; set; }
        public string errorMessage { get; set; }
    }
}