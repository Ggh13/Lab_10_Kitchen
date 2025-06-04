using Model.Data;
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

        public static void StartMap()
        {

            var rest = new Model.Core.Map.Restaurant("Clot Mone", "Oguzk chef?!?!?! NO WAY!");
            Model.Core.Map.Map.AddVenue(rest);

            var cafe = new Model.Core.Map.Cafe("Arcabalene", "There are many krab`s burgers");
            Model.Core.Map.Map.AddVenue(cafe);




            var cafe2 = new Model.Core.Map.Cafe("Рыба и мясо", "There are many krab`s burgers");
            Model.Core.Map.Map.AddVenue(cafe2);

            var rest2 = new Model.Core.Map.Restaurant("Victor", "There are many krab`s burgers");
            Model.Core.Map.Map.AddVenue(rest2);

            var FF1 = new Model.Core.Map.FastFood("STOLOVKA MISIS", "There are many krab`s burgers");
            Model.Core.Map.Map.AddVenue(FF1);



            var FF2 = new Model.Core.Map.FastFood("DYAGILEV", "There are many krab`s burgers");
            Model.Core.Map.Map.AddVenue(FF2);

            for (int i = 0; i < Map.Venues.Length; i++)
            {
                MainSerialializer.SaveMenu(Map.Venues[i].Menus[0], true);
                
            }
        }

    }
}
