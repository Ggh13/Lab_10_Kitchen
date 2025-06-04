using Model.Core.MealDir;
using Model.Core.MenuDir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;
namespace Model.Core.Map
{
    

     public abstract partial class Venue : IVenue
    {

        //private Menu[]

        public Venue(string name, string description)
        {
            _name = name;
            _description = description;
            _menus = new Menu[2];
            _menus[0] = new DefaultMenu(name);
            
            _menus[1] = new SeasonMenu(name);
            if(MainSerialializer.LoadMenu(_menus[1].MyId, _menus[1].NameOfVen) != null)
            {
                haveSeasonMenu = true;

                //_menus[1] = MainSerialializer.LoadMenu(_menus[1].MyId, _menus[1].NameOfVen);
            }
            
        }

        public void AddSeasonMenu()
        {
            if (!haveSeasonMenu)
            {
                haveSeasonMenu = true;

                

                MainSerialializer.SaveMenu(_menus[1], true);

                _menus[1] = MainSerialializer.LoadMenu(_menus[1].MyId, _menus[1].NameOfVen);
            }
            
        }
    }

}
