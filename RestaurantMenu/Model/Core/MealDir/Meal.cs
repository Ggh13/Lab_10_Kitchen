using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.MealDir
{
    public abstract class Meal : IMeal
    {
        public string Name => name;
        public int Price => price;


        protected string name;
        protected int price;
        public void SetPrice(int price) {
            price = price;
        }
        public void SetName(string name) {
            name = name;
        }

        public Meal(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string Type
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public override string ToString()
        {
            return $"{Name}, {Price} рублей";
        }

    }
}
