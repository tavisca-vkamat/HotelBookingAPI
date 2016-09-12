using HotelBooking.customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookingService" in both code and config file together.
    [ServiceContract]
    public interface IBookingService
    {
        [OperationContract]
        BookingStatus BookRoom(BookingDeatils bookingDetails);
    }

    [DataContract]
    public class BookingStatus
    {
        BookingDeatils bookingDetails;
        string errorMessage;

        public BookingDeatils BookingDetails
        {
            get
            {
                return bookingDetails;
            }

            set
            {
                bookingDetails = value;
            }
        }

        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }

            set
            {
                errorMessage = value;
            }
        }
    }

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

