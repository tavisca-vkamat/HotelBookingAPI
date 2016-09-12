using HotelBooking.bookingService;
using System.ServiceModel;

namespace HotelBooking
{
    [ServiceContract]
    public interface IBookingService
    {
        [OperationContract]
        BookingStatus BookRoom(BookingDeatils bookingDetails);
    }
}

