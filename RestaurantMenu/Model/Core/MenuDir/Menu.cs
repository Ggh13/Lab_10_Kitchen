using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Core.MealDir;
using Model.Data;
using Newtonsoft.Json;
namespace Model.Core.MenuDir
{
    public abstract partial class Menu : IMenu
    {

        protected static int id = 0;
        protected string nameOfVen;
        protected int my_id;
        public int MyId => my_id;
        public string NameOfVen => nameOfVen;
        //public int Id { get { return id; } }
        [JsonConstructor]
        public Menu(string nameV) {

            id += 1;
            
            _meals = new Meal[0];
            nameOfVen = nameV;
           
        }

        public Menu()
        {

            _meals = new Meal[0];

           //MainSerialializer.LoadMenu();


        }

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
            Model.Data.Serializer ser = new Model.Data.JsonSerializer();
            ser.Serialize(this);
        }
        public void LoadMenu(int id)
        {
            Model.Data.Serializer ser = new Model.Data.JsonSerializer();

           // var menu = ser.Deserialize<Menu>(Id);
           // id = menu.Id;
            //_meals = menu.Meals;

        }

    }
}
