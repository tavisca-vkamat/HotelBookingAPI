﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.bookingService
{
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
}