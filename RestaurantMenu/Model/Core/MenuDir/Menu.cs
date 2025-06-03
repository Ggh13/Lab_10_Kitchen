using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Core.MealDir;
using Model.Data;
namespace Model.Core.MenuDir
{
    public abstract partial class Menu : IMenu
    {
        protected static int id = 0;
        public int Id { get { return id; } }
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

        public override string ToString() {
            return Type;
        }

        public void SaveMenu()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(this);
        }
        public void LoadMenu()
        {

        }

    }
}
