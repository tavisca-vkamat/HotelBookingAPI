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
        [DataMember]
        public List<Room> rooms { get; set; }
        [DataMember]
        public string messsage { get; set; }

    }
}