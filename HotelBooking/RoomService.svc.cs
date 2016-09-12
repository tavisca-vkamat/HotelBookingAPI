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
        public List<Room> GetRooms(RoomFilter roomfilter)

        {
<<<<<<< HEAD
            List<Room> rooms = new List<Room>();
           
                string cityname = roomfilter.CityName;               
                
                string city = "..\\..\\..\\data\\rooms\\" + roomfilter.CityName.ToLower() + "\\" + roomfilter.Hotelid.ToLower() + ".XML";            
                rooms = SerializeOperations.XMLDeSerializeRooms(city);                  
                rooms = RoomFilterOperations.FilterByRate(rooms, roomfilter.Rate);
                rooms = RoomFilterOperations.FilterByAmenities(rooms, roomfilter.Amenities);                
=======
           
                string roomFIlePath = "..\\..\\..\\data\\rooms\\" + roomfilter.CityName.ToLower() + "\\" + roomfilter.Cityroomid +
                                      ".XML";
                 List<Room> rooms = SerializeOperations.XMLDeSerializeRooms(roomFIlePath);
          
            rooms = RoomFilterOperations.FilterByRate(rooms, roomfilter.Rate);
            rooms = RoomFilterOperations.FilterByAmenities(rooms, roomfilter.Amenities);

>>>>>>> 77e1400c294cc65b3be519ba2ddbaeebfea3234d
            return rooms;
        }
    }
    
}
