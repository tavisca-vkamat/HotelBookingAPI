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
        public List<Hotel> GetHotels(string cityName)
        {
            List<Hotel> hotels = new List<Hotel>();
            for (int hotelId = 1; ; hotelId++)
            {
                string city = "..\\..\\..\\data\\hotels\\" + cityName.ToLower() + "\\" + hotelId + ".XML";
                Hotel hotel = (Hotel)SerializeOperations.XMLDeSerializeHotel(city, typeof(Hotel));
                if (hotel == null)
                    break;
                else
                    hotels.Add(hotel);
            }
            return hotels;
        }
    }
}
