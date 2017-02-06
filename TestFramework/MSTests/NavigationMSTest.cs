using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.MSTests
{
    [TestClass()] 
    public class NavigationMSTest
    {
        public TestContext TestContext { get; set; }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            DataSourseCSV.GetTestCaseData(6);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            @"C: \Users\Valiantsin_Lopan\Documents\Visual Studio 2015\Projects\TestFramework\TestFramework\TestData\Data.csv",
            "Data#csv",
            DataAccessMethod.Sequential)]
        public void NavigationTestMS()
        {
            var journalName = TestContext.DataRow["Journal"].ToString();
            var menuItem = TestContext.DataRow["MenuItem"].ToString();
            Steps.OpenJournal(journalName);
            Assert.IsTrue(Steps.ChekMenuElement(menuItem), $"Problem in{journalName} in {menuItem} ");
        }
    }
}
