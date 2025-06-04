using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using Model.Core.MealDir;
using Model.Core.MenuDir;
using System.Security.Cryptography;
using System.Diagnostics;
namespace Model.Data
{
    public class JsonSerializer: Serializer
    {
        public override T Deserialize<T>(int id, string nameV)
        {
            if (!Directory.Exists(PathFolder))
            {
                Directory.CreateDirectory(PathFolder);
            }
 
            
            var file_path = Path.Combine(PathFolder, $"{nameV}_{id}.json");
            
            if (!File.Exists(file_path))
                return new SeasonMenu() as T;
            
            try
            {
                string jsonContent = File.ReadAllText(file_path);
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto // Для корректной работы с абстрактным классом
                };

                Menu sm = default( Menu );

                
                var f =  JsonConvert.DeserializeObject<dynamic>(jsonContent, settings);

                if (f["Type"].ToString() == "DefaultMenu")
                {


                    sm = new DefaultMenu(f["NameOfVen"].ToString(), int.Parse(f["MyId"].ToString()));
                }
                else
                {

                    sm = new DefaultMenu(f["NameOfVen"].ToString(), int.Parse(f["MyId"].ToString()));

                }
                foreach (var meal in f.Meals)
                {
                    var Meal = default(Meal);
                    if (meal.Type.ToString() == "Salad")
                    {
                        Meal = new Salad(meal.Name.ToString(), int.Parse(meal.Price.ToString()));
                    }
                    else
                    {
                        Meal = new Drink(meal.Name.ToString(), int.Parse(meal.Price.ToString()));
                    }
                    sm.AddMeal(Meal);

                }

                    return sm as T;
            }
            catch (JsonException ex)
            {
                // Логирование ошибки при необходимости
                Console.WriteLine($"Ошибка десериализации: {ex.Message}");
                return new string ("pppp") as T;
            }
        }

        public override void Serialize<T>(T data)
        {
            if (!Directory.Exists(PathFolder))
            {
                Directory.CreateDirectory(PathFolder);
            }
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };

            var ser = JsonConvert.SerializeObject(data, settings);
            string file_path = "";

            
            
           var menu = (data as Menu);
           file_path = Path.Combine(PathFolder, menu.NameOfVen.ToString() + "_" + menu.MyId.ToString() + ".json");
            
            
            File.WriteAllText(file_path, ser);
        }

    }
}
