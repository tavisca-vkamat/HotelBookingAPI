using HotelBooking.hotelService;
using System.Collections.Generic;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HotelService : IHotel
    {
        public HotelStatus GetHotels(HotelFilter hotelFilter)
        {
            HotelStatus hotelStatus= new HotelStatus();

            hotelStatus.hotels = new List<Hotel>();

            /* Get List of hotels by city name */
            for (int hotelId = 1; ; hotelId++)
            {
                string city = string.Format("..\\..\\..\\data\\hotels\\{0}\\{1}.XML", hotelFilter.CityName.ToLower(), hotelId);
                Hotel hotel = (Hotel)SerializeOperations.XMLDeSerializeHotel(city, typeof(Hotel));
                if (hotel == null)
                    break;
                else
                {
                    hotel.Amenities = hotel.Amenities.Trim();
                    hotelStatus.hotels.Add(hotel);
                }
            }

            /* filter for minimum rate */
            hotelStatus.hotels = HotelFilterOperations.FilterByRate(hotelStatus.hotels, hotelFilter.MinRate);
            if (hotelStatus.hotels == null)
            {
                hotelStatus.errorMessage = string.Format("Rooms not available for {0}", hotelFilter.MinRate);
                return hotelStatus;
            }

            /* filter for rating */
            hotelStatus.hotels = HotelFilterOperations.FilterByRating(hotelStatus.hotels, hotelFilter.Rating);
            if (hotelStatus.hotels == null)
            {
                hotelStatus.errorMessage = string.Format("Rooms not available for {0}", hotelFilter.MinRate);
                return hotelStatus;
            }

            /* filter for amenities */
            hotelStatus.hotels = HotelFilterOperations.FilterByAmenities(hotelStatus.hotels, hotelFilter.Amenities);
            if (hotelStatus.hotels == null)
            {
                hotelStatus.errorMessage = string.Format("Rooms not available for {0}", hotelFilter.MinRate);
                return hotelStatus;
            }

            return hotelStatus;
        }
    }
}
