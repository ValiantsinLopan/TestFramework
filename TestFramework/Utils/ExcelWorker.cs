using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using TestFramework.JournalClasses;

namespace TestFramework.Utils
{
    public class ExcelWorker
    {
        public static string filePath = TestData.BatchPath;
        public static Excel.Application excelApp;
        public static Excel.Workbook excelWorkbook;


        public static IList<Excel.Worksheet> GetJournalsWorkSheets(int batchNumber)
        {
            excelWorkbook = ExcelGetter.OpenBatch(batchNumber);
            var excelSheets = excelWorkbook.Worksheets;
            IList<Excel.Worksheet> journals = new List<Excel.Worksheet> (); 
            foreach (Excel.Worksheet worksheet in excelWorkbook.Worksheets)
            {
                journals.Add(worksheet);
            }
            return journals;
            
        }
        
        public static  Navigation GetNavigation(Excel.Worksheet worksheet)
        {
            var navigation = new Navigation();
            int rowStart = 2;
            int columnStart = 1;
            Excel.Range range = worksheet.Cells[rowStart,columnStart];
            
            while (range.Value != null )
            {
                var menu = new Menu(range.Value.ToString());
                rowStart++;
                range = worksheet.Cells[rowStart, columnStart];
                while (range.Value!= null)
                {
                    menu.AddMenuItem(new MenuItem(range.Value.ToString()));
                    rowStart++;
                    range = worksheet.Cells[rowStart, columnStart];
                    
                }
                navigation.AddMenu(menu);
                columnStart++;
                rowStart = 2;
                range = worksheet.Cells[rowStart, columnStart];
                
            }
            return navigation;
            
        }

        public static Journal GetJournal(string journalName,int batchNumber)
        {
            Journal journal = new Journal(journalName,GetNavigation(ExcelGetter.GetWorkSheet(journalName,batchNumber)));
            return journal;
        }

        public static  List<Journal> GetJournals(int batchNumber)
        {
            IList<Excel.Worksheet> journalSheets = GetJournalsWorkSheets(batchNumber);
            List<Journal> journals = new List<Journal>();
            int countOfJournals = journalSheets.Count;
            foreach(Excel.Worksheet journalSheet in journalSheets)
            {
                string name = journalSheet.Name;
                journals.Add(new Journal(name,GetNavigation(journalSheet)));
            }
            return journals;
        } 

        public static List<string> GetExcelColumn(int columnNum, string filePath)
        {
            excelApp = new Excel.Application();
            excelWorkbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet workSheet = excelWorkbook.Worksheets[1];
            List<string> parameters = new List<string>();
            int rowStart = 1;
            int columnStart = columnNum;
            Excel.Range range = workSheet.Cells[rowStart, columnStart];
            while(range.Value != null)
            {
                parameters.Add(range.Value.Tostring());
                rowStart++;
                range = workSheet.Cells[rowStart, columnStart];
            }
            excelApp.Quit();
            return parameters;
        }
        
        public static List<Login> GetUserlist(string filePath)
        {
            excelApp = new Excel.Application();
            excelWorkbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet workSheet = excelWorkbook.Worksheets[1];
            List<Login> users = new List<Login>();
            int rowStart = 1;
            int columnStart = 1;
            Excel.Range username = workSheet.Cells[rowStart, columnStart];
            Excel.Range password = workSheet.Cells[rowStart, columnStart + 1];
            while (username.Value != null)
            {
                users.Add(new Login(username.Value.ToString(),password.Value.ToString()));
                rowStart++;
                username = workSheet.Cells[rowStart, columnStart];
                password = workSheet.Cells[rowStart, columnStart + 1];
            }
            excelApp.Quit();
            return users;
        }
    }
       
}
