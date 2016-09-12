using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBooking;
using System.Collections.Generic;

namespace HotelTests
{
    [TestClass]
    public class HotelTest
    {
        [TestMethod]
        public void TestXmlHotelRead()
        {
            string[] amenities = { "Restaurant" };
            List<Hotel> hotels = new HotelService().GetHotels(new HotelFilter("pune", "4", "3000", amenities));

            Assert.IsNotNull(hotels);
        }

        [TestMethod]
        public void TestXmlRoomsRead()
        {

<<<<<<< HEAD
            string[] amenities = {"Wifi"};
            List<Room> rooms = new RoomService().GetRooms(new RoomFilter("goa1","goa","2000",amenities));          
=======
            string[] amenities = { "Accommodation only" };        
            List<Room> rooms = new RoomService().GetRooms(new RoomFilter("pune","pune1","5000",amenities));
           
>>>>>>> 77e1400c294cc65b3be519ba2ddbaeebfea3234d
            Assert.IsNotNull(rooms);
        }
    }
}
