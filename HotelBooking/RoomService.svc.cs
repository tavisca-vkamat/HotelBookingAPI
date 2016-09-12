using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RoomService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RoomService.svc or RoomService.svc.cs at the Solution Explorer and start debugging.
    public class RoomService : IRoom
    {
        public List<Room> GetRooms(RoomFilter roomfilter)

        {

            string roomFIlePath = "..\\..\\..\\data\\rooms\\" + roomfilter.CityName.ToLower() + "\\" + roomfilter.Cityroomid +
                                  ".XML";
            List<Room> rooms = SerializeOperations.XMLDeSerializeRooms(roomFIlePath);

            rooms = RoomFilterOperations.FilterByRate(rooms, roomfilter.Rate);
            rooms = RoomFilterOperations.FilterByAmenities(rooms, roomfilter.Amenities);

            return rooms;
        }

        public double GetRate(string cityName, string roomId)
        {
            string hotelId = roomId.Split('_')[0].ToLower();
            string roomPath = string.Format("..\\..\\..\\data\\rooms\\{0}\\{1}.XML", cityName, hotelId);

            var xmlStr = File.ReadAllText(roomPath);
            var str = XElement.Parse(xmlStr);

            var result = str.Elements("Room").
        Where(x => x.Element("Id").Value.Equals(roomId));

            return double.MinValue;
        }
    }
}

