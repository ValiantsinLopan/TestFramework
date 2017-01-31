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
        public void GetJournalsWorkSheetsTest()
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
            string filePath = "D:/VALIANTSIN/TAT LAB/TestFramework task/Styling/Responsive-Batch-6.xlsx";

            var workSheet = ExcelGetter.GetWorkSheet("lbjnewsletter", filePath);
            Navigation nav = ExcelWorker.GetNavigation(workSheet);
            Console.WriteLine(nav.ToString());

        }

        [TestMethod()]
        public void GetJournalTest()
        {
            List<Journal> jrn = ExcelWorker.GetJournal();
            Console.WriteLine(jrn[1].nav.menu[0].menuItem[0].ToString());
        }
    }
}