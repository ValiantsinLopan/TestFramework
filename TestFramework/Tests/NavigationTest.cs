using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestFramework.JournalClasses;
using TestFramework;
using TestFramework.JournalPageObjects;
using TestFramework.Utils;

namespace TestFramework.Tests
{
    [TestFixture()]
    class NavigationTest
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCases")]
        public void TestNavigation(Journal journal)
        {
            Steps.OpenJournal(journal.Name);
            foreach(Menu menu in journal.nav.menu)
            {
                Assert.IsTrue(Steps.ChekMenuElement(menu.Name),"Problem in menu "+ menu.Name + " from "+journal.Name);
                foreach( MenuItem item in menu.menuItem)
                {
                    Assert.IsTrue(Steps.ChekMenuElement(item.Name), "Problem in menu item "+item.Name+" from " + journal.Name);
                }

            }
           
        }

        [TestFixtureTearDown]
        public static void Cleanup()
        {
            WD.WebDriver.KillDriver();
        }
    }

    public class TestCasesProvider
    {
        public static List<TestCaseData> TestCases()
        {
            List<Journal> list = ExcelWorker.GetJournals(6);
            var testCases  = new List<TestCaseData>();
            foreach (var journal in list)
            {
                testCases.Add( new TestCaseData(journal));
            }
            return testCases;
        }

    }


}