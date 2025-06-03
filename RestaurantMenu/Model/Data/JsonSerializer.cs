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
namespace Model.Data
{
    public class JsonSerializer: Serializer
    {
        public T Deserialize<T>(int id)
        {
            var file_path = Path.Combine(PathFolder, id.ToString() + ".json");
            Menu menu = JsonConvert.DeserializeObject<Menu>(file_path);
            if (menu is T result)
                return result;
            return default(T);
        }

        public void Serialize<T>(T data)
        {
            
            
            var ser = JsonConvert.SerializeObject(data);
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
