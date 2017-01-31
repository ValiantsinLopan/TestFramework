using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.JournalClasses
{
     public class Menu
    {
        public static string Name { get; set; }
        public List<MenuItem> menuItem = new List<MenuItem>();
        public Menu(string name)
        {
            Name = name;
            
        }
        public void AddMenuItem(string item)
        {
            menuItem.Add(new MenuItem(item));
        }
        public static string GetName()
        {
            return Name;
        }
    }
}
