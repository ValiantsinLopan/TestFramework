using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestFramework
{
    public class ExcelGetter
    {
        public static string filePath = @"D:\Data for training\Styling\Responsive-Batch-6.xlsx";
        public static Excel.Application excelApp;
        public static Excel.Workbook excelWorkbook;

        public static Excel.Workbook OpenBatch(string filePath)
        {
            excelApp = new Excel.Application() { Visible = true };
            excelWorkbook = excelApp.Workbooks.Open(filePath);
            return excelWorkbook;
        }
        public static Excel.Worksheet GetWorkSheet(string name, string filePath) 
        {
            var excelWorkbook = OpenBatch(filePath);
            Excel.Worksheet workSheet = excelWorkbook.Worksheets[name];
            return workSheet;
        }
    }
}
