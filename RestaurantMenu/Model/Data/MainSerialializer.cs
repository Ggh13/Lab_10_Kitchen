using Model.Core.MenuDir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model.Data
{
    public static class MainSerialializer
    {
        private static string format = "json";
        public static void ChangeFormat(string Newformat)
        {
            if (Newformat == "json")
            {
                format = "json";
            }
            else{
                format = "xml";
            }
        }
        public static Menu LoadMenu(int id_menu, string nameV)
        {

            Menu res = null;

            var xmlFile = Path.Combine(Serializer.pathFolder, nameV + "_" + id_menu.ToString() + ".xml");
            var jsonFile = Path.Combine(Serializer.pathFolder, nameV + "_" + id_menu.ToString() + ".json");
            Serializer ser = default(Serializer);
            if (File.Exists(xmlFile))
            {
                ser = new XMLSerializer();
                ChangeFormat("xml");
            }
            else if(File.Exists(jsonFile))
            {
                ser = new JsonSerializer();
                ChangeFormat("json");

            }
            else
            {
                return null;
            }
            res = ser.Deserialize<Menu>(id_menu, nameV);
            return res;
        }

        public static void SaveMenu(Menu menu_to_save, bool just_cre = false)
        {


            var xmlFile = Path.Combine(Serializer.pathFolder, menu_to_save.NameOfVen + "_" + menu_to_save.MyId.ToString() + ".xml");
            var jsonFile = Path.Combine(Serializer.pathFolder, menu_to_save.NameOfVen + "_" + menu_to_save.MyId.ToString() + ".json");

            if (just_cre)
            {
                if (File.Exists(xmlFile))
                {
                    return;
                }
                else if (File.Exists(jsonFile))
                {
                    return;

                }
            }
            



            Serializer ser = default(Serializer);
            string file_to_del = Path.Combine(Serializer.pathFolder, menu_to_save.NameOfVen + "_" +  menu_to_save.MyId.ToString());
            if (format == "xml")
            {
                ser = new XMLSerializer();
                file_to_del = file_to_del + ".json";
            }
            else
            {
                file_to_del = file_to_del + ".xml";
                ser = new JsonSerializer();
            }
            File.Delete(file_to_del);
            ser.Serialize(menu_to_save);
        }
    }
}
