using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using TestFramework.JournalClasses;
using TestFramework.MSTests;

namespace TestFrameworkTests
{
    [TestClass]
    public class DataSourceCSVTest
    {
        [TestMethod]
        public void GetDataSourceCSV()
        {
            DataSourseCSV.GetTestCaseData(6);

        }
    }
}
