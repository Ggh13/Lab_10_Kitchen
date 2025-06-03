using Model.Core.MenuDir;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.Data
{

    public class XMLSerializer : Serializer
    {
        public T Deserialize<T>(string path)
        {
            var file_path = Path.Combine(PathFolder, menu.Id.ToString() + ".json");
            Menu res;
            var sir = new XmlSerializer(typeof(Menu));
            Menu desir;
            using (var reader = new StreamReader(file_path))
            {
                res = (Menu)sir.Deserialize(reader);
            }
            if (res is T result)
                return result;
            return default(T);
        }

        public void Serialize<T>(T data, string path)
        {
            var ser = JsonConvert.SerializeObject(data);
            string file_path = "";
            if (data is Menu)
            {
                var menu = data as Menu;
                file_path = Path.Combine(PathFolder, menu.Id.ToString() + ".json");

                var sir = new XmlSerializer(typeof(Menu));
                using (var writer = new StreamWriter(file_path))
                {
                    sir.Serialize(writer, menu);
                }
            }
        }
    }

}
