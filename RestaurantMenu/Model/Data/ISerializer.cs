using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public interface ISerializer
    {
       
       public void Serialize<T>(T data);

        public T Deserialize<T>(int id);
    }
}
