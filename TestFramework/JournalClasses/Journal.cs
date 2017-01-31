using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.JournalClasses
{
    public class Journal
    {
        string Name { get; set; }
        public Navigation nav;
        public Journal(string Name,Navigation nav)
        {
            this.Name = Name;
            this.nav = nav;    
        }
        public static string GetURL()
        {
            return Name;
        }
    }

}
