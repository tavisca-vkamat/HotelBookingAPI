using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace HotelBooking
{
    [XmlRoot("Rooms")]
    public class RoomsList
    {
        [XmlElement("Room")]
        public List<Room> rooms { get; set; }
    }
}