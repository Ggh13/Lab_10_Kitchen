using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Core.MealDir;

namespace Model.Core.MenuDir
{
    public interface IMenu
    {
        Meal[] OpenMenu();
        void CloseMenu();
        void AddMeal(Meal meal) ;
        void DeleteMeal(Meal meal) ;
        void SaveMenu();
        void LoadMenu(int id);

        Meal[] Meals { get; }
        string Type { get; }
    }
}
