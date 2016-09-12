using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Serialization;
using HotelBooking.roomService;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRoomService" in both code and config file together.
    [ServiceContract]
    public interface IRoom
    {
        [OperationContract]
        RoomStatus GetRooms(RoomFilter roomfilter);
    }
}
