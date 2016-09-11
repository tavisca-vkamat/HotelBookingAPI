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
        List<Room> GetRooms(string cityName, string hotelId);
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
