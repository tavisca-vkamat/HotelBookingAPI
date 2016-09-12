using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HotelBooking.hotelService
{
    [DataContract]
    public class HotelStatus
    {
        [DataMember]
        public List<Hotel> hotels { get; set; }

        [DataMember]
        public string errorMessage { get; set; }
    }
}