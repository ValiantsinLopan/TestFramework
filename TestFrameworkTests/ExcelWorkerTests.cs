using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using TestFramework.JournalClasses;
using TestFramework.Utils;


namespace TestFramework.Tests
{
    
    [TestClass()]
    public class ExcelWorkerTests
    {
        [TestMethod()]
        public void GetJournalsWorkSheetsTest()
        {
            IList<Excel.Worksheet> test = ExcelWorker.GetJournalsWorkSheets(6);
            foreach (Excel.Worksheet t in test)
            {
                Console.WriteLine(t.Name.ToString());
            }

        }

        [TestMethod()]
        public void GetNavigationTest()
        {
            string filePath = "D:/Data for training/Styling/Responsive-Batch-6.xlsx";

            var workSheet = ExcelGetter.GetWorkSheet("lbjnewsletter", 6);
            Navigation nav = ExcelWorker.GetNavigation(workSheet);
            Console.WriteLine(nav.ToString());

        }

        [TestMethod()]
        public void GetJournalTest()
        {
            Journal j = ExcelWorker.GetJournal("pain",6);
            Console.WriteLine(j.Name.ToString());
        }

        [TestMethod()]
        public void GetJournalsTest()
        {
            List<Journal> jrn = ExcelWorker.GetJournals(6);
            Console.WriteLine(jrn[1].nav.menu[0].menuItem[0].Name.ToString());
        }

        
    }
    
}