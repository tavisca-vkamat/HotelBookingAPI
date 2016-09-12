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
        string hotelid;
        string cityName;
        string cityroomid;
        string rate;
        string[] amenities;
       
<<<<<<< HEAD
        public RoomFilter(string hotelid,string cityName, string rate, string[] amenities)
        {
            this.hotelid = hotelid;
            this.cityName = cityName;
=======
        public RoomFilter(string cityname,string cityroomid,string rate, string[] amenities)
        {
            this.cityName = cityname;
            this.cityroomid = cityroomid;
>>>>>>> 77e1400c294cc65b3be519ba2ddbaeebfea3234d
            this.rate = rate;
            this.amenities = amenities;
            
        }
<<<<<<< HEAD
        public string Hotelid
        {
            get
            {
                return hotelid;
=======
        public string Cityroomid
        {
            get
            {
                return cityroomid;
>>>>>>> 77e1400c294cc65b3be519ba2ddbaeebfea3234d
            }

            set
            {
<<<<<<< HEAD
                hotelid = value;
=======
                cityroomid = value;
>>>>>>> 77e1400c294cc65b3be519ba2ddbaeebfea3234d
            }
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
<<<<<<< HEAD

=======
>>>>>>> 77e1400c294cc65b3be519ba2ddbaeebfea3234d
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
