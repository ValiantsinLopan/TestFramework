using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Journal
{
    public class Navigation
    {
        public List<Menu> menu;
        public Navigation()
        {
        }
        public void AddMenu(Menu item)
        {
            menu.Add(item);
        }
    }
}
