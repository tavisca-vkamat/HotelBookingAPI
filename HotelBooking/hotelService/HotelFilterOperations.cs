using HotelBooking.hotelService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace HotelBooking
{

    internal class HotelFilterOperations
    {
        internal static List<Hotel> FilterByRate(List<Hotel> hotels, string minRate)
        {
            for (int hotel = 0; hotel < hotels.Count();)
            {
                bool flagOfBreak = false;
                if (double.Parse(hotels[hotel].RateMin) > double.Parse(minRate))
                {
                    hotels.Remove(hotels[hotel]);
                    flagOfBreak = true;
                }
                if (!flagOfBreak)
                    hotel++;
            }
            return hotels;
        }

        internal static List<Hotel> FilterByRating(List<Hotel> hotels, string rating)
        {
            for (int hotel = 0; hotel < hotels.Count(); )
            {
                bool flagOfBreak = false;
                if (double.Parse(hotels[hotel].Rating) < double.Parse(rating))
                {
                    hotels.Remove(hotels[hotel]);
                    flagOfBreak = true;
                }
                if (!flagOfBreak)
                    hotel++;
            }
            return hotels;
        }

        internal static List<Hotel> FilterByAmenities(List<Hotel> hotels, string[] amenities)
        {

            for (int amenity = 0; amenity < amenities.Count(); amenity++)
                amenities[amenity] = amenities[amenity].Trim().ToLower();

            for (int hotel = 0; hotel < hotels.Count();)
            {
                bool flagOfBreak = false;
                foreach (string amenity in amenities)
                {
                    if (!hotels[hotel].Amenities.ToLower().Contains(amenity))
                    {
                        hotels.Remove(hotels[hotel]);
                        flagOfBreak = true;
                        break;
                    }
                }
                if (!flagOfBreak)
                    hotel++;
            }
            return hotels;
        }
    }
}