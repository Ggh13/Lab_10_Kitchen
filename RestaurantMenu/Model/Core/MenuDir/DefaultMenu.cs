using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.MenuDir
{
    public class DefaultMenu : Menu
    {

        public DefaultMenu() 
        {
            my_id = id;
        }
        public DefaultMenu(string nameV) : base(nameV) {

            my_id = id;
        }
        public DefaultMenu(string nameV, int id) : base(nameV)
        {
            my_id = id;
        }

    }
}
