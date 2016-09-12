using System.Runtime.Serialization;

namespace HotelBooking.bookingService
{
    [DataContract]
    public class BookingStatus
    {
        [DataMember]
        BookingDeatils bookingDetails;

        [DataMember]
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
}