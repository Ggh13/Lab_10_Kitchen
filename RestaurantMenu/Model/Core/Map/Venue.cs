using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.Map
{
    public  abstract partial class Venue : IVenue
    {
        protected string _name;
        protected string _description;

        public string Name => _name;
        public string Description => _description;

        //private Menu[]

       
    }

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
