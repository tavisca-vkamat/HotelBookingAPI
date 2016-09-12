using HotelBooking.bookingService;
using HotelBooking.customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelBooking
{
    [ServiceContract]
    public interface IBookingService
    {
        [OperationContract]
        BookingStatus BookRoom(BookingDeatils bookingDetails);
    }
}

