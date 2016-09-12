using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace HotelBooking
{
    internal class RoomFilterOperations
    {
        internal static List<Room> FilterByRate(List<Room> rooms, string rate)
        {
            for (int room = 0; room < rooms.Count(); room++)
            {
                if (double.Parse(rooms[room].Rate) > double.Parse(rate))
                    rooms.Remove(rooms[room]);
            }
            return rooms;
        }

        internal static List<Room> FilterByAmenities(List<Room> rooms, string[] amenities)
        {
<<<<<<< HEAD


            List<Room> finalrooms = new List<Room>();
            for (int room = 0; room < rooms.Count(); room++)
            {
                rooms[room].Amenities.ToLower();

                for (int i = 0; i < amenities.Count(); i++)
                {

                    bool flag = false;

                    if (!rooms[room].Amenities.Contains(amenities[i]))
                    {
                      //  rooms.RemoveAt(room);
                        
                    }




                }

=======
            for (int amenity = 0; amenity < amenities.Count(); amenity++)
                amenities[amenity] = amenities[amenity].Trim().ToLower();

            for (int room = 0; room < rooms.Count();)
            {
                bool flagOfBreak = false;
                foreach (string amenity in amenities)
                {
                    if (!rooms[room].Amenities.ToLower().Contains(amenity))
                    {
                        rooms.Remove(rooms[room]);
                        flagOfBreak = true;
                        break;
                    }
                }
                if (!flagOfBreak)
                    room++;
>>>>>>> 77e1400c294cc65b3be519ba2ddbaeebfea3234d
            }





            //for (int room = 0; room < rooms.Count; room++)
            //{
                         
            //    string phrase = rooms[room].Amenities;
            //    phrase = Regex.Replace(phrase, @"\s", "");
            //    string[] values = phrase.Split(',');

            //    for (int i = 0; i < values.Length; i++)
            //    {
            //        values[i] = values[i].Trim();
            //    }

            //    foreach (string s in amenities)
            //    {
            //        s.ToLower();
            //    }
            //    foreach (string s in values)
            //    {
            //        s.ToLower();
            //    }                            
            
            //    //checking the two strings are equal or not
            //        bool areEqual = amenities.SequenceEqual(values);
            //        if(areEqual == true)
            //    {
            //        finalrooms.Add(rooms[room]);

            //    }
            //    else
            //        {
            //            rooms.Remove(rooms[room]);
            //        }            
            //}
            return finalrooms;
        }
    }
}