using HotelBooking.hotelService;
using System.ServiceModel;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHotel
    {
        [OperationContract]
        HotelStatus GetHotels(HotelFilter hotelFilter);
    }
}
