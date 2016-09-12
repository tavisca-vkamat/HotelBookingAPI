using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HotelBooking.roomService
{
    [DataContract]
    public class RoomStatus
    {

        public List<Room> rooms { get; set; }

        public string messsage { get; set; }

    }
}