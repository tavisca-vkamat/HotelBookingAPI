using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace HotelBooking.roomService
{
    [DataContract]
    [XmlRoot("Room")]
    public class Room
    {
        [DataMember]
        string id;
        [DataMember]
        string type;
        [DataMember]
        string rate;
        [DataMember]
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