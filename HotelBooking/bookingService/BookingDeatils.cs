using HotelBooking.customer;
using System;
using System.Runtime.Serialization;

namespace HotelBooking.bookingService
{
    [DataContract]
    public class BookingDeatils
    {
        public string City { get; set; }
        public string RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { set; get; }
        public DateTime BookingDate { set; get; }
        public string BookingId { set; get; }
        public int numberOfGuests { set; get; }
        public int numberOfRooms { set; get; }
        public Customer customer { set; get; }
        public double TotalPrice { get; set; }
    }
}