using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.Map
{
    public static class Map
    {
        private static Venue[] venues = new Venue[0];

        public static Venue[] Venues => venues;

        public static string Name => "name";


        public static void AddVenue(Venue new_venue)
        {
            Array.Resize(ref venues, venues.Length + 1);
            venues[venues.Length - 1] = new_venue;
        }
        public static void DrawRestaurant()
        {

        }

    }
}
