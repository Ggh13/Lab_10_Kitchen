using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.MealDir
{
    public interface IMeal
    {
        void SetPrice(int price) ;
        void SetName(string name) ;
        string Type { get; }
    }
}
