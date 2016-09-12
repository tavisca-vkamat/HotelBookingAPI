namespace HotelBooking.hotelService
{
    public class Hotel
    {
        string id;
        string name;
        string email;
        string city;
        string area;
        string rating;
        string rateMin;
        string rateMax;
        string amenities;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

        public string Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public string RateMin
        {
            get
            {
                return rateMin;
            }

            set
            {
                rateMin = value;
            }
        }

        public string RateMax
        {
            get
            {
                return rateMax;
            }

            set
            {
                rateMax = value;
            }
        }

        public string Amenities
        {
            get
            {
                return amenities;
            }

            set
            {
                amenities = value;
            }
        }
    }
}