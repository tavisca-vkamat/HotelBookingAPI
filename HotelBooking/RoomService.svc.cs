using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RoomService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RoomService.svc or RoomService.svc.cs at the Solution Explorer and start debugging.
    public class RoomService : IRoom
    {
        public List<Room> GetRooms(string cityName, string hotelId)
        {
            string roomFIlePath = "..\\..\\..\\data\\rooms\\" + cityName.ToLower() + "\\" + hotelId.ToLower() + ".XML";

            List<Room> rooms = SerializeOperations.XMLDeSerializeRooms(roomFIlePath);

            return rooms;
        }
    }
    
}
