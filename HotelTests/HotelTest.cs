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

            List<Hotel> hotels = new HotelService().GetHotels("pune");

            Assert.IsNotNull(hotels);
        }

        [TestMethod]
        public void TestXmlRoomsRead()
        {
            List<Room> rooms = new RoomService().GetRooms("goa","GOA5");
            Console.WriteLine(rooms);
            Assert.IsNotNull(rooms);
        }
    }
}
