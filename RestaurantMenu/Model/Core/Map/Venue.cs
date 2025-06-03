using Model.Core.MealDir;
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

        //private Menu[]

        public Venue(string name, string description)
        {
            _name = name;
            _description = description;
            _menus = new Menu[1];
        }

        public void AddSeasonMenu()
        {
            if (!haveSeasonMenu)
            {
                haveSeasonMenu = true;

               

                Menu[] updatedMeals = new Menu[_menus.Length + 1];

                Array.Copy(_menus, updatedMeals, _menus.Length);
                updatedMeals[_menus.Length] = new SeasonMenu();

                _menus = updatedMeals;
            }
            
        }
    }

}
