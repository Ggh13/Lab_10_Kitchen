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
    
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Map.StartMap();

            MapForm mf = new RestaurantMenu.MapForm();
            Application.Run(mf);
        }

        /*
        public static string checkGS()
        {

            DefaultMenu dm = (DefaultMenu)MainSerialializer.LoadMenu(6, "DYAGILEV");
            dm.AddMeal(new Drink("2222", 12));
            MainSerialializer.SaveMenu(dm);

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
        */
    }
}