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
        public static string filePath = @"D:\Data for training\Styling\Responsive-Batch-6.xlsx";
        public static Excel.Application excelApp;
        public static Excel.Workbook excelWorkbook;

        public static List<Excel.Worksheet> GetJournalsWorkSheets()
        {
            // Excel.Application excelApp = new Excel.Application();
            // Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
            excelApp = new Excel.Application();
            excelWorkbook = excelApp.Workbooks.Open(filePath);
            var excelSheets = excelWorkbook.Worksheets;
            List<Excel.Worksheet> journals = new List<Excel.Worksheet>();
            foreach (Excel.Worksheet worksheet in excelWorkbook.Worksheets)
            {
                journals.Add(worksheet);
            }
            return journals;
        }

        [TestMethod()]
        public void GetJournalsWorkSheetsTest()
        {
            var jorn = GetJournalsWorkSheets();

            foreach (var jo in jorn)
            {
                Console.WriteLine(jo.ToString());

            }
            Console.ReadKey();
        }

        [TestMethod()]
        public void GetNavigationTest()
        {
            string filePath = @"D:\Data for training\Styling\Responsive-Batch-6.xlsx";
            Excel.Application excelApp;
            Excel.Workbook excelWorkbook;
            excelApp = new Excel.Application();
            excelWorkbook = excelApp.Workbooks.Open(filePath);
            var excelSheet = excelWorkbook.Worksheets;
            Navigation nav = new Navigation();
            
        }
            
        


        [TestMethod()]
        public void GetJournalTest()
        {
            Assert.Fail();
        }
    }
}