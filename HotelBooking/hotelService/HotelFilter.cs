using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.hotelService
{
    public class HotelFilter
    {
        string cityName;
        string rating;
        string minRate;
        string[] amenities;

        public HotelFilter(string cityName, string rating, string minRate, string[] amenities)
        {
            this.cityName = cityName;
            this.rating = rating;
            this.minRate = minRate;
            this.amenities = amenities;
        }

        public string CityName
        {
            get
            {
                return cityName;
            }

            set
            {
                cityName = value;
            }
        }

        public string Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public string MinRate
        {
            get
            {
                return minRate;
            }

            set
            {
                minRate = value;
            }
        }

        public string[] Amenities
        {
            get
            {
                return amenities;
            }

            set
            {
                amenities = value;
            }
        }
    }
}