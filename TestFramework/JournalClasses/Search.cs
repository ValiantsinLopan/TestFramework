using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.JournalClasses
{
    public class Search
    {
        public string request { get; set; }

        public Search(string request)
        {
            this.request = request;
        }
    }
}
