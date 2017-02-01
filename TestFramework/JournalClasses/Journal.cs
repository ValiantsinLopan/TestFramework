using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.JournalClasses
{
    public class Journal
    {
        public string Name { get ; set; }
        public Navigation nav;
        public Journal(string name,Navigation Nav)
        {
            Name = name;
            nav = Nav;    
        }
        
    }

}
