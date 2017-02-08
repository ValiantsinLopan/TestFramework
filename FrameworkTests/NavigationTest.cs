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
using TestFramework.WD;
using TestFramework.Steps;

namespace FrameworkTests
{
    [TestFixture()]
    class NavigationTest
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCases")]
        public void TestNavigation(Journal journal)
        {
            Step.OpenJournal(journal.Name);
            foreach(Menu menu in journal.nav.menu)
            {
                Assert.IsTrue(Step.ChekMenuElement(menu.Name),"Problem in menu "+ menu.Name + " from "+journal.Name);
                foreach( MenuItem item in menu.menuItem)
                {
                    Assert.IsTrue(Step.ChekMenuElement(item.Name), "Problem in menu item "+item.Name+" from " + journal.Name);
                }

            }
           
        }

        [TestFixtureTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
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