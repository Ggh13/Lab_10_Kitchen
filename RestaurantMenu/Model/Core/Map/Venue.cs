using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.Map
{
    

     public abstract partial class Venue : IVenue
    {

        //private Menu[]

        public Venue(string name, string description)
        {
            _name = name;
            _description = description;
        }
    }

}
