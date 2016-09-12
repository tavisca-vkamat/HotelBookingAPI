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
            }
            return rooms;
        }
    }
    }