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
        public override T Deserialize<T>(int id)
        {

 
            
            var file_path = Path.Combine(PathFolder, $"{id}.json");

            if (!File.Exists(file_path))
                return new SeasonMenu() as T;

            try
            {
                string jsonContent = File.ReadAllText(file_path);
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto // Для корректной работы с абстрактным классом
                };

                SeasonMenu sm = (SeasonMenu)JsonConvert.DeserializeObject<SeasonMenu>(jsonContent, settings);
                
                if (sm == null)
                {   
                    return new SeasonMenu() as T;
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

        public void Serialize<T>(T data)
        {

            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };

            var ser = JsonConvert.SerializeObject(data, settings);
            string file_path = "";

            
            if (data is Menu)
            {
                var menu = data as Menu;
                file_path = Path.Combine(PathFolder, menu.Id.ToString() + ".json");
            }
            
            File.WriteAllText(file_path, ser);
        }

    }
    public class Test
    {
        public Test()
        {

        }
        public string name = " ";
    }
}
