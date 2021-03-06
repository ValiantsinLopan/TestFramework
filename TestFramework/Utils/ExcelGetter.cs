﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using TestFramework.Settings;

namespace TestFramework.Utils
{
    public class ExcelGetter
    {
        public static string filePath = SettingsPaths.Default.BatchPath;
        public static Excel.Application excelApp;
        public static Excel.Workbook excelWorkbook;

        public static Excel.Workbook OpenBatch(int batchNumber)
        {
            excelApp = new Excel.Application() { Visible = false};
            excelWorkbook = excelApp.Workbooks.Open($@"D:\Data for training\Styling\Responsive-Batch-{batchNumber}.xlsx");
            //excelWorkbook = excelApp.Workbooks.Open($@"D:\VALIANTSIN\TAT LAB\TestFramework task\Styling\Responsive-Batch-{batchNumber}.xlsx");

            //excelApp.Quit();
            return excelWorkbook;
            
        }
        public static Excel.Worksheet GetWorkSheet(string name, int batchNumber) 
        {
            var excelWorkbook = OpenBatch(batchNumber);
            Excel.Worksheet workSheet = excelWorkbook.Worksheets[name];
            return workSheet;
        }
        ~ExcelGetter()
        {
            Dispose();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing) return;
            excelApp?.Quit();
        }
    }
}
