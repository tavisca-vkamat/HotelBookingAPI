using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HotelService : IHotel
    {
        public List<Hotel> GetHotels(HotelFilter hotelFilter)
        {
            List<Hotel> hotels = new List<Hotel>();
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
                    hotels.Add(hotel);
                }
            }

            /* filter for minimum rate */
            hotels = HotelFilterOperations.FilterByRate(hotels, hotelFilter.MinRate);

            /* filter for rating */
            hotels = HotelFilterOperations.FilterByRating(hotels, hotelFilter.Rating);

            /* filter for amenities */
            hotels = HotelFilterOperations.FilterByAmenities(hotels, hotelFilter.Amenities);

            return hotels;
        }

    }
}
