using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using TestFramework.JournalClasses;


namespace TestFramework.Tests
{
    [TestClass()]
    public class ExcelWorkerTests
    {
        [TestMethod()]
        public  void GetJournalsWorkSheetsTest()
        {
            IList<Excel.Worksheet> test = ExcelWorker.GetJournalsWorkSheets();
            foreach (Excel.Worksheet t in test)
            {
                Console.WriteLine(t.Name.ToString());
            }

        }

        [TestMethod()]
        public void GetNavigationTest()
        {
            string filePath = "D:/Data for training/Styling/Responsive-Batch-6.xlsx";

           var workSheet = ExcelGetter.GetWorkSheet("lbjnewsletter", filePath);
            Navigation nav = ExcelWorker.GetNavigation(workSheet);
            Console.WriteLine(nav.ToString());
        }
    }
}