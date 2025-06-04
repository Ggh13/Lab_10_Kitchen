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
        public readonly static string pathFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Kitchen");
        public string PathFolder { get { return pathFolder; } }
        public virtual T Deserialize<T>(int id, string nameV) where T : Menu
        {
            return default(SeasonMenu) as T;
        }

        public virtual void Serialize<T>(T data)
        {

        }
    }
}
