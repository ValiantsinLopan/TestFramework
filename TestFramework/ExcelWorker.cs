﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using TestFramework.JournalClasses;

namespace TestFramework
{
    public class ExcelWorker
    {
        public static string filePath = @"D:\Data for training\Styling\Responsive-Batch-6.xlsx";
        public static Excel.Application excelApp;
        public static Excel.Workbook excelWorkbook;

        public static IList<Excel.Worksheet> GetJournalsWorkSheets()
        {
            // Excel.Application excelApp = new Excel.Application();
            // Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
            excelApp = new Excel.Application();
            excelWorkbook = excelApp.Workbooks.Open(filePath);
            var excelSheets = excelWorkbook.Worksheets;
            IList<Excel.Worksheet> journals = new List<Excel.Worksheet> (); 
            foreach (Excel.Worksheet worksheet in excelWorkbook.Worksheets)
            {
                journals.Add(worksheet);
            }
            return journals;
            excelApp.Quit();
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


        public  List<Journal> GetJournal()
        {
            IList<Excel.Worksheet> journalSheets = GetJournalsWorkSheets();
            List<Journal> journals = new List<Journal>();
            int countOfJournals = journalSheets.Count;
            foreach(Excel.Worksheet journalSheet in journalSheets)
            {
                string name = journalSheet.Name;
                journals.Add(new Journal(name,GetNavigation(journalSheet)));
            }
           
            return journals;
        } 
        
    }
       
}