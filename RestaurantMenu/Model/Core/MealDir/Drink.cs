using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Core.MealDir
{
    public class Drink : Meal
    {
        public Drink(string name, int price, string description) : base(name, price, description) { }
    }
}