using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Journal
{
     public class Menu
    {
        public static string Name { get; set; }
        public List<MenuItem> menuItem;
        public Menu(string name)
        {
            name = Name;
            
        }
        public void AddMenuItem(MenuItem item)
        {
            menuItem.Add(item);
        }

    }
}
