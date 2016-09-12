using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using HotelBooking.roomService;
using HotelBooking.bookingService;

namespace HotelBooking
{
    public class SerializeOperations
    {
        public static void WriteXML(BookingDeatils bookingDetails)
        {
            XmlSerializer writer = new XmlSerializer(typeof(BookingDeatils));

            var path = string.Format("D:\\training\\WCF\\HotelBookingAPI\\BookingDetails\\{0}.xml", bookingDetails.BookingId);
            FileStream file = File.Create(path);

            writer.Serialize(file, bookingDetails);
            file.Close();
        }

        /* get object from XML file */
        public static object XMLDeSerializeHotel(string filePath, Type objectType)
        {
            object objectToReturn = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(objectType);
                StreamReader file = new StreamReader(@filePath);

                objectToReturn = serializer.Deserialize(file);
            }
            catch (FileNotFoundException)
            {
            }
            return objectToReturn;
        }

        public static List<Room> XMLDeSerializeRooms(string filePath)
        {

            XDocument xmltest = XDocument.Load(@filePath);
            List<Room> Roomlist = new List<Room>();

            var nodes = (from n in xmltest.Descendants("Room")
                         select new
                         {
                             Id = (string)n.Element("Id").Value,
                             Type = (string)n.Element("Type").Value,
                             Rate = (string)n.Element("Rate").Value,
                             Amenities = (string)n.Element("Amenities").Value

                         }).ToList();

            foreach (var n in nodes)
            {
                Room room = new Room();
                room.Id = n.Id;
                room.Type = n.Type;
                room.Rate = n.Rate;
                room.Amenities = n.Amenities;
                Roomlist.Add(room);
            }
            return Roomlist;
        }
    }
}