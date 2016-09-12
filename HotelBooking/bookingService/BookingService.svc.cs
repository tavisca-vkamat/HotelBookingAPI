using HotelBooking.bookingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookingService.svc or BookingService.svc.cs at the Solution Explorer and start debugging.
    public class BookingService : IBookingService
    {
        Random _r = new Random();
        public BookingStatus BookRoom(BookingDeatils bookingdetails)
        {
            BookingStatus bookingstatus = new BookingStatus();

            bookingstatus.BookingDetails = bookingdetails;

            bookingdetails.BookingDate = DateTime.Now;
            bookingdetails.TotalPrice = CalculatePrice(bookingdetails.City, bookingdetails.RoomId, bookingdetails.numberOfRooms);
            bookingdetails.BookingId = _r.Next().ToString();

            if (bookingstatus.BookingDetails != null)
            {
                SerializeOperations.WriteXML(bookingstatus.BookingDetails);
                bookingstatus.ErrorMessage = "Booking successful";
            }
            else
                bookingstatus.ErrorMessage = "Booking details invalid";

            return bookingstatus;
        }

        private double CalculatePrice(string cityName, string roomId, int numberOfRooms)
        {
            double roomRate = new RoomService().GetRate(cityName, roomId) * numberOfRooms;

            return roomRate;
        }

    }
}
