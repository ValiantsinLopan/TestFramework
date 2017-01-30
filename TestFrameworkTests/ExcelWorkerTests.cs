using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace TestFramework.Tests
{
    [TestClass()]
    public class ExcelWorkerTests
    {
        [TestMethod()]
        public void GetJournalsNamesTest()
        {
            List<string> jorn = ExcelWorker.GetJournalsNames();
            foreach (string jo in jorn)
            {
                Console.WriteLine(jo.ToString());
                Console.ReadKey();
            }
        }

      /*  [TestMethod()]
        public void GetNavigationTest()
        {
            List<string> jorn = ExcelWorker.GetNavigation();
            foreach (string jo in jorn)
            {
                Console.WriteLine(jo.ToString());
                Console.ReadKey();
            }
        }
        */
    }
}