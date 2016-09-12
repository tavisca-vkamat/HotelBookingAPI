using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;
using HotelBooking.roomService;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RoomService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RoomService.svc or RoomService.svc.cs at the Solution Explorer and start debugging.
    public class RoomService : IRoom
    {
        public RoomStatus GetRooms(RoomFilter roomfilter)
        {

            string roomFIlePath = "C:\\Users\\nmandge\\Desktop\\vvk\\HotelBookingAPI\\data\\rooms\\" + roomfilter.CityName.ToLower() + "\\" + roomfilter.HotelId +
                                  ".XML";
            List<Room> rooms = SerializeOperations.XMLDeSerializeRooms(roomFIlePath);
            RoomStatus roomstatus = new RoomStatus();
            roomstatus.rooms = rooms;

            if (roomfilter.Rate != null)
            {
                rooms = RoomFilterOperations.FilterByRate(rooms, roomfilter.Rate);
                if(rooms.Count() == 0)
                    roomstatus.messsage = "Enter Rates does not have any Match";

                return roomstatus;
            }
            
            if (roomfilter.Amenities != null)
            {
                rooms = RoomFilterOperations.FilterByAmenities(rooms, roomfilter.Amenities);
                if (rooms.Count() == 0)
                    roomstatus.messsage = "Enter Amenities does not have any Match";

                return roomstatus;
            }

            return roomstatus;
        }

        public double GetRate(string cityName, string roomId)
        {
            string hotelId = roomId.Split('_')[0].ToLower();
            string roomPath = string.Format("..\\..\\..\\data\\rooms\\{0}\\{1}.XML", cityName, hotelId);

            var xmlStr = File.ReadAllText(roomPath);
            var str = XElement.Parse(xmlStr);

            var result = str.Elements("Room").
        Where(x => x.Element("Id").Value.Equals(roomId));

            return double.Parse(result.First().Element("Rate").Value);
        }
    }
}

