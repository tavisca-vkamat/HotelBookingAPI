using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBooking;
using HotelBooking.hotelService;
using HotelBooking.bookingService;


using HotelBooking.roomService;
using System;

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
            string[] amenities = { "Wifi" };
            RoomStatus roomstatus = new RoomService().GetRooms(new RoomFilter("goa", "goa1", "2000", amenities));


            Assert.IsNotNull(roomstatus);
        }

        [TestMethod]
        public void TestXmlBookRoom()
        {
            BookingDeatils bookingdetails = new BookingDeatils();
            bookingdetails.RoomId = "PUNE1_1";
            bookingdetails.City = "pune";
            bookingdetails.numberOfRooms = 1;
            bookingdetails.CheckInDate= DateTime.Now;
            bookingdetails.CheckOutDate = DateTime.Now;
            bookingdetails.numberOfGuests = 1;
            bookingdetails.customer = new HotelBooking.customer.Customer();
            bookingdetails.customer.FirstName = "Vivek";
            bookingdetails.customer.LastName = "Kamat";
            bookingdetails.customer.PhoneNumber = "8975025201";
            bookingdetails.customer.EmailId = "vvkamat@gmail.com";
            bookingdetails.RoomId = "PUNE1_1";
            


            BookingStatus status = new BookingService().BookRoom(bookingdetails);

            Assert.IsNotNull(status);
        }
    }
}
