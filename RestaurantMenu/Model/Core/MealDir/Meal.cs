using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.MealDir
{
    public abstract class Meal : IMeal
    {
        protected string Name { get; set; }
        protected int Price { get; set; }

        public void SetPrice(int price) { 
            Price = price;
        }
        public void SetName(string name) {
            Name = name;
        }

        public Meal(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Type
        {
            get
            {
                return this.GetType().Name;
            }
        }

    }
}
