using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Serialization;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRoomService" in both code and config file together.
    [ServiceContract]
    public interface IRoom
    {
        [OperationContract]
        List<Room> GetRooms(RoomFilter roomfilter);
    }

    [DataContract]
    public class RoomFilter
    {
        string cityName;
        string hotelId;
        string rate;
        string[] amenities;

        public RoomFilter(string cityname, string hotelId, string rate, string[] amenities)
        {
            cityName = cityname;
            HotelId = hotelId;
            this.rate = rate;
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

    [XmlRoot("Room")]
    public class Room
    {
        string id;
        string type;
        string rate;
        string amenities;

        [XmlElement("Id")]
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [XmlElement("Type")]
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        [XmlElement("Rate")]
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

        [XmlElement("Amenities")]
        public string Amenities
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
