using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}
