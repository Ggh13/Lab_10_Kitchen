using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Model.Core.MealDir;
using Model.Core.MenuDir;

namespace Model.Data
{
    public class XMLSerializer: Serializer
    {

        public override T Deserialize<T>(int id, string nameV) 
        {
            if (!Directory.Exists(PathFolder))
            {
                Directory.CreateDirectory(PathFolder);
            }
            Menu res = null;
            MenuDTO desir;
            var sir = new XmlSerializer(typeof(MenuDTO));
            using (var reader = new StreamReader(Path.Combine(PathFolder, nameV.ToString() + "_" + id.ToString() + ".xml")))
            {
                desir = (MenuDTO)sir.Deserialize(reader);
            }
            if (desir.Type == "DefaultMenu")
            {
                res = new DefaultMenu(nameV, id);
            }
            else
            {
                res = new SeasonMenu(nameV, id);
            }

            for (int i = 0; i < desir.Meals.Length; i++)
            {

                if (desir.Meals[i].type == "Salad")
                {
                    res.AddMeal(new Salad(desir.Meals[i].name, desir.Meals[i].price));
                }
                else if(desir.Meals[i].type == "Drink")
                {
                    res.AddMeal(new Drink(desir.Meals[i].name, desir.Meals[i].price));
                }
                else if (desir.Meals[i].type == "Dessert")
                {
                    res.AddMeal(new Dessert(desir.Meals[i].name, desir.Meals[i].price));
                }
                else
                {
                    res.AddMeal(new HotDish(desir.Meals[i].name, desir.Meals[i].price));
                }
                
            }

            return res as T;
        }

        public override void Serialize<T>(T data)
        {
            if (!Directory.Exists(PathFolder))
            {
                Directory.CreateDirectory(PathFolder);
            }
            var sir = new XmlSerializer(typeof(MenuDTO));


            MenuDTO mN = new MenuDTO(data as Menu);
            string xml = Path.Combine(PathFolder, mN.nameOfVen.ToString() + "_" + mN.Id.ToString() + ".xml");
            using (var writer = new StreamWriter(xml))
            {
                sir.Serialize(writer, mN);
            }
        }

        public class DTOMeal
        {
            public string name;
            public int price;

            public string type;
            public DTOMeal()
            {

            }
            public DTOMeal(Meal ml)
            {
                name = ml.Name;
                price = ml.Price;
                type = ml.Type;
            }
        }
        public class MenuDTO
        {
            public string nameOfVen;
            public int Id;
            public MenuDTO(Menu menu)
            {
                Id = menu.MyId;
                nameOfVen = menu.NameOfVen;
                Meals = new DTOMeal[menu.Meals.Length];
                for(int i = 0; i < menu.Meals.Length; i++)
                {
                    Meals[i] = new DTOMeal(menu.Meals[i]);
                }
                Type = menu.Type;
            }

            public MenuDTO(){ }


            public DTOMeal[] Meals;

            public string Type;

        }



    }
}