using Model;
using Model.Data;
using Model.Core;
using Model.Core.Map;
using RestaurantMenu;
using RestaurantMenu.RestaurantMenu;
using Model.Core.MenuDir;
using Model.Core.MealDir;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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




            

            MessageBox.Show(JsonSerDesir());




            MapForm mf = new RestaurantMenu.MapForm();
            Application.Run(mf);
        }

        public static string JsonSerDesir()
        {
            Serializer sir = new JsonSerializer();


            SeasonMenu menu = new SeasonMenu();

            Meal meal1 = new Salad("buabes", 100);
            Console.WriteLine("!!!!!22------");
            menu.AddMeal(meal1);

            sir.Serialize(menu);


            var ans = sir.Deserialize<Model.Core.MenuDir.Menu>(1);
            if(ans == null)
            {
                return "?";
            }
            sir.Serialize(ans);
            return "allDone";
        }

        public static void xml()
        {
            SeasonMenu menu = new SeasonMenu();

            Meal meal1 = new Salad("buabes", 100);
            Console.WriteLine("!!!!!22------");
            menu.AddMeal(meal1);

            XMLSerializer.SerializeMenu(menu, Path.Combine(Serializer.pathFolder, menu.Id.ToString() + ".xml"));
            var men = (Model.Core.MenuDir.Menu)XMLSerializer.DeserializeMenu(Path.Combine(Serializer.pathFolder, menu.Id.ToString() + ".xml"));
            men.AddMeal(meal1);
            menu.AddMeal(meal1);
            menu.AddMeal(meal1);
            XMLSerializer.SerializeMenu(menu, Path.Combine(Serializer.pathFolder, menu.Id.ToString() + ".xml"));

        }
    }
}