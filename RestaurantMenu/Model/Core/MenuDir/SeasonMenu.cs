using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.MenuDir
{
    public class SeasonMenu : Menu
    {


        public SeasonMenu()
        {

            my_id = id;
        }
        public SeasonMenu(string nameV) : base(nameV)
        {

            my_id = id;
        }
        public SeasonMenu(string nameV, int id) : base(nameV) {

            my_id = id;

        }
    }
}
