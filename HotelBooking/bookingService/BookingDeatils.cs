using HotelBooking.customer;
using System;
using System.Runtime.Serialization;


namespace HotelBooking.bookingService
{
    [DataContract]
    public class BookingDeatils
    {
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string RoomId { get; set; }
        [DataMember]
        public DateTime CheckInDate { get; set; }
        [DataMember]
        public DateTime CheckOutDate { set; get; }
        [DataMember]
        public DateTime BookingDate { set; get; }
        [DataMember]
        public string BookingId { set; get; }
        [DataMember]
        public int numberOfGuests { set; get; }
        [DataMember]
        public int numberOfRooms { set; get; }
        [DataMember]
        public Customer customer { set; get; }
        [DataMember]
        public double TotalPrice { get; set; }
    }
}