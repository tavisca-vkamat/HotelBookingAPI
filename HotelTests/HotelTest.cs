using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBooking;
using System.Collections.Generic;
using HotelBooking.hotelService;
using HotelBooking.bookingService;

namespace HotelTests
{
    [TestClass]
    public class HotelTest
    {
        [TestMethod]
        public void TestXmlHotelRead()
        {
            string[] amenities = { "Restaurant" };
            HotelStatus status = new HotelService().GetHotels(new HotelFilter("pune", "4", "3000", amenities));

            Assert.IsNotNull(status);
        }

        [TestMethod]
        public void TestXmlRoomsRead()
        {
            string[] amenities = {"Wifi"};
            List<Room> rooms = new RoomService().GetRooms(new RoomFilter("goa","goa1","2000",amenities));          

            Assert.IsNotNull(rooms);
        }

        [TestMethod]
        public void TestXmlBookRoom()
        {
            BookingDeatils bookingdetails = new BookingDeatils();
            bookingdetails.RoomId = "PUNE1_1";
            bookingdetails.City = "pune";
            bookingdetails.numberOfRooms = 1;


            BookingStatus status  = new BookingService().BookRoom(bookingdetails);

            Assert.IsNotNull(status);
        }
    }
}
