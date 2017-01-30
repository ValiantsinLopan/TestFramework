using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using TestFramework.Journal;

namespace TestFramework
{
    public class ExcelWorker
    {
        public static string filePath = @"D:\Data for training\Styling\Responsive-Batch-6.xlsx";
        public static Excel.Application excelApp;
        public static Excel.Workbook excelWorkbook;

        public static List<string> GetJournalsNames()
        {
            // Excel.Application excelApp = new Excel.Application();
            // Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
            excelApp = new Excel.Application();
            excelWorkbook = excelApp.Workbooks.Open(filePath);
            var excelSheets = excelWorkbook.Worksheets;
            List<string> journals = new List<String>(); 
            foreach (Excel.Worksheet worksheet in excelWorkbook.Worksheets)
            {
                journals.Add(worksheet.Name);
            }
            return journals;
        }
        
        public static Navigation GetNavigation(Excel.Worksheet worksheet)
        {
            var navigation = new Navigation();
  
            
            int rowStart = 2;
            int columnStart = 1;
            var range = worksheet.Cells[rowStart,columnStart];
            //var menu = new Menu(range.Value.ToString());
            while (range.Value != null )
            {
                var menu = new Menu(range.Value.ToString());
                rowStart++;
                range = worksheet.Cells[rowStart, columnStart];
                
                while (range.Value!= null)
                {
                    menu.AddMenuItem(range.Value.ToString());
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
        
    }
       
}
