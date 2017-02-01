using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.JournalClasses
{
     public class Menu
    {
        public string Name { get; set; }
        public List<MenuItem> menuItem = new List<MenuItem>();
        public Menu(string name)
        {
            Name = name;
            
        }
        public void AddMenuItem( MenuItem item)
        {
            menuItem.Add(item);
        }
        
    }
}
