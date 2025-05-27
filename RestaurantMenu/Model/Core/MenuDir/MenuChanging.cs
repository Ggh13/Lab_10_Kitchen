using Model.Core.MealDir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.MenuDir
{
    public abstract partial class Menu : IMenu
    {

        public void DeleteMeal(Meal meal)
        {
            _meals = _meals.Where(m => m != meal).ToArray();
        }

        public static Menu operator +(Menu menu, Meal meal)
        {
            Meal[] updatedMeals = new Meal[menu._meals.Length + 1];
            Array.Copy(menu._meals, updatedMeals, menu._meals.Length);
            updatedMeals[updatedMeals.Length - 1] = meal;

            menu._meals = updatedMeals;
            return menu;
        }

        public void AddMeal(Meal meal)
        {
            var _ = this + meal;
        }
    }
}
