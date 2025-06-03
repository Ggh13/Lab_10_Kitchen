using Model.Core.MenuDir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.Data
{
    public abstract class Serializer : ISerializer
    {
        public readonly static string pathFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string PathFolder { get { return pathFolder; } }
        public virtual T Deserialize<T>(int id) where T : Menu
        {
            return default(SeasonMenu) as T;
           // throw default(object);
        }

        public virtual void Serialize<T>(T data)
        {
    /*
            var file_path = Path.Combine(PathFolder, data.Id.ToString() + ".json");
            SelectFile(fileName);
            WaterJumpSeril res = new WaterJumpSeril(participant);
            var sir = new XmlSerializer(typeof(WaterJumpSeril));
            using (var writer = new StreamWriter(FilePath))
            {
                sir.Serialize(writer, res);
            }
    */

        }
    }
}
