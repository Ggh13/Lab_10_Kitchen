using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Core.MealDir;

namespace Model.Core.MenuDir
{
    public abstract class Menu : IMenu
    {
        public Menu() { }

        private Meal[] _meals;

        public Meal[] Meals { get { return _meals; } }

        public string Type
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public Meal[] OpenMenu() {
            return Meals;
        }
        public void CloseMenu() { }
        public void AddMeal(Meal meal) {
            Array.Resize(ref _meals, _meals.Length + 1);
            _meals[_meals.Length - 1] = meal;
        }
        public void DeleteMeal(Meal meal) {
            _meals = _meals.Where(m => m != meal).ToArray();
        }

    }
}
