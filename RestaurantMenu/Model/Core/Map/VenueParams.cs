using Model.Core.MenuDir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.Map
{
    public abstract partial class Venue : IVenue
    {
        protected string _name;
        protected string _description;

        public string Name => _name;
        public string Description => _description;

        public bool HaveSeasonMenu => haveSeasonMenu;
        protected bool haveSeasonMenu = false;

        public Menu[] Menus => _menus;
        private Menu[] _menus;


    }
}
