using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.Data
{
    public abstract class Serializer : ISerializer
    {
        protected string pathFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string PathFolder { get { return pathFolder; } }
        public T Deserialize<T>(int id)
        {
            throw new NotImplementedException();
        }

        public void Serialize<T>(T data)
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
