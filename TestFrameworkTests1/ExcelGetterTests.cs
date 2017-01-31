﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class ExcelGetterTests
    {
        [TestMethod()]
        public void GetWorkSheetTest()
        {
            Excel.Worksheet sh = ExcelGetter.GetWorkSheet("nursingmadeincrediblyeasy", "D:/Data for training/Styling/Responsive-Batch-6.xlsx");
            Console.WriteLine(sh.Name);
        }
    }
}