using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HotelBooking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHotel
    {
        [OperationContract]
        List<Hotel> GetHotels(HotelFilter hotelFilter);
    }

    [DataContract]
    public class HotelFilter
    {
        string cityName;
        string rating;
        string minRate;
        string[] amenities;

        public HotelFilter(string cityName, string rating, string minRate, string[] amenities)
        {
            this.cityName = cityName;
            this.rating = rating;
            this.minRate = minRate;
            this.amenities = amenities;
        }

        public string CityName
        {
            get
            {
                return cityName;
            }

            set
            {
                cityName = value;
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

        public string MinRate
        {
            get
            {
                return minRate;
            }

            set
            {
                minRate = value;
            }
        }

        public string[] Amenities
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


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
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
