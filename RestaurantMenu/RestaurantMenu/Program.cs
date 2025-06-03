using Model;
using Model.Data;
using Model.Core;
using Model.Core.Map;
using RestaurantMenu;
using RestaurantMenu.RestaurantMenu;
using Model.Core.MenuDir;
using Model.Core.MealDir;

namespace RestaurantMenu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            var rest = new Model.Core.Map.Restaurant("Clot Mone", "Oguzk chef?!?!?! NO WAY!");
            Model.Core.Map.Map.AddVenue(rest);

            var cafe = new Model.Core.Map.Cafe("The Krusty Krab", "There are many krab`s burgers");
            Model.Core.Map.Map.AddVenue(cafe);

            var cafe2 = new Model.Core.Map.Cafe("The Krusty Krab", "There are many krab`s burgers");
            Model.Core.Map.Map.AddVenue(cafe2);

            var rest2 = new Model.Core.Map.Restaurant("The Krusty Krab", "There are many krab`s burgers");
            Model.Core.Map.Map.AddVenue(rest2);

            var FF1 = new Model.Core.Map.FastFood("The Krusty Krab", "There are many krab`s burgers");
            Model.Core.Map.Map.AddVenue(FF1);

            var FF2 = new Model.Core.Map.FastFood("The Krusty Krab", "There are many krab`s burgers");
            Model.Core.Map.Map.AddVenue(FF2);

            /*
            var menu = new SeasonMenu();
            
            Meal meal1 = new Salad("buabes", 100);
            
            menu.AddMeal(meal1);
            
            menu.AddMeal(meal1);
            */
            MapForm mf = new RestaurantMenu.MapForm();
            Application.Run(mf);
        }
    }
}