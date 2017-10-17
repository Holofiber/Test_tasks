using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorMenu
{
    public class Menu : MenuItem
    {
        public List<MenuItem> MenuItems;

        public Menu(string name) : base(name)
        {
            MenuItems = new List<MenuItem>();
        }
    }
}
