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
    public static class XMLSerializer
    {
        public static void SerializeMenu(Menu menu, string filePath)
        {
            try
            {
                var wrapper = new MenuWrapper(menu);
                var serializer = new XmlSerializer(typeof(MenuWrapper));

                var settings = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "  "
                };

                using (var writer = XmlWriter.Create(filePath, settings))
                {
                    serializer.Serialize(writer, wrapper);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error serializing menu", ex);
            }
        }

        public static Menu DeserializeMenu(string filePath)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(MenuWrapper));

                using (var reader = XmlReader.Create(filePath))
                {
                    var wrapper = (MenuWrapper)serializer.Deserialize(reader);
                    return wrapper.ToMenu();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing menu", ex);
            }
        }

        [XmlRoot("Menu")]
        public class MenuWrapper
        {
            [XmlAttribute("Id")]
            public int Id { get; set; }

            [XmlAttribute("Type")]
            public string Type { get; set; }

            [XmlArray("Meals")]
            [XmlArrayItem("Meal")]
            public List<MealWrapper> Meals { get; set; }

            public MenuWrapper() { }

            public MenuWrapper(Menu menu)
            {
                Id = menu.Id;
                Type = menu.Type;
                Meals = menu.Meals.Select(m => new MealWrapper(m)).ToList();
            }

            public Menu ToMenu()
            {

                Menu menu = null;

                if (menu != null)
                {
                    var meals = Meals.Select(m => m.ToMeal()).ToArray();
                    var field = typeof(Menu).GetField("_meals",
                        System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    field?.SetValue(menu, meals);
                }

                return menu;
            }
        }

        public class MealWrapper
        {
            [XmlAttribute("Name")]
            public string Name { get; set; }

            [XmlAttribute("Price")]
            public int Price { get; set; }

            [XmlAttribute("Type")]
            public string Type { get; set; }

            public MealWrapper() { }

            public MealWrapper(Meal meal)
            {
                Name = meal.Name;
                Price = meal.Price;
                Type = meal.Type;
            }

            public Meal ToMeal()
            {

                Meal meal = null;

                return meal;
            }
        }
    }
}