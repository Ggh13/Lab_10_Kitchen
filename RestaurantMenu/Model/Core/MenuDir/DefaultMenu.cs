using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.MenuDir
{
    public class DefaultMenu : Menu
    {
        public DefaultMenu() : base() {
            id += 1;
            this.SaveMenu();
        }
    }
}
