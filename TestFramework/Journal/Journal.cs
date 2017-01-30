using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Journal
{
    class Journal
    {
        string Name { get; set; }
        public Navigation nav;
        public Journal(string Name)
        {
        this.Name = Name;
            
        }
    }

}
