using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HotelBooking.roomService
{
    [DataContract]
    public class RoomFilter
    {
        [DataMember]
        string cityName;
        [DataMember]
        string hotelId;
        [DataMember]
        string rate;
        [DataMember]
        string[] amenities;

        public RoomFilter(string cityname, string hotelId, string rate, string[] amenities)
        {
            cityName = cityname;
            HotelId = hotelId;
            this.rate = rate;
            this.amenities = amenities;

        }
        public RoomFilter(string cityname, string hotelId, string rate)
        {
            cityName = cityname;
            HotelId = hotelId;
            this.rate = rate;
        }
        public RoomFilter(string cityname, string hotelId)
        {
            cityName = cityname;
            HotelId = hotelId;


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
        public string Rate
        {
            get
            {
                return rate;
            }

            set
            {
                rate = value;
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

        public string HotelId
        {
            get
            {
                return hotelId;
            }

            set
            {
                hotelId = value;
            }
        }
    }
}