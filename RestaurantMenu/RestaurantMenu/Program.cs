using Model;
using Model.Data;
using Model.Core;
using Model.Core.Map;
using RestaurantMenu;
using RestaurantMenu.RestaurantMenu;
using Model.Core.MenuDir;
using Model.Core.MealDir;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace RestaurantMenu
{
    public static class Program
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

            //DefaultMenu menu = new DefaultMenu();

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




            MapForm mf = new RestaurantMenu.MapForm();
            Application.Run(mf);
        }


        public static string checkGS()
        {
            

            //MainSerialializer.SaveMenu(MainSerialializer.LoadMenu(0, "NAME"), "xml");

            return "allDone";
        }
        public static string JsonSerDesir()
        {
            Serializer sir = new JsonSerializer();


            SeasonMenu menu = new SeasonMenu("GGG");

            Meal meal1 = new Salad("buabes", 100);
            Console.WriteLine("!!!!!22------");
            menu.AddMeal(meal1);

            sir.Serialize(menu);


            var ans = sir.Deserialize<Model.Core.MenuDir.Menu>(menu.MyId, menu.NameOfVen);

            if(ans == null)
            {
                return "?";
            }
            ans.AddMeal(meal1);
            ans.AddMeal(meal1);
            sir.Serialize(ans);
            return ans.NameOfVen;
        }

        public static string xml()
        {

            DefaultMenu menu = new DefaultMenu("NAME");

            Meal meal1 = new Salad("buabes", 100);
            Console.WriteLine("!!!!!22------");
            menu.AddMeal(meal1);
           
            
            Serializer serializer = new XMLSerializer();

            serializer.Serialize(menu);

            var d = serializer.Deserialize<Model.Core.MenuDir.Menu>(menu.MyId, menu.NameOfVen);
            serializer.Serialize(d);

            return "All Done";
            

        }
    }
}