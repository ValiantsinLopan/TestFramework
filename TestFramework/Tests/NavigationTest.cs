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

namespace TestFramework.Tests
{
    [TestFixture()]
    class NavigationTest
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCases")]
        public void TestMethod(Journal journal)
        {
            Steps.OpenJournal(journal.Name);
            foreach(Menu menu in journal.nav.menu)
            {
                Assert.IsTrue(Steps.ChekMenuElement(menu.Name),"Problem in "+journal.Name+" "+menu.Name);
                foreach( MenuItem item in menu.menuItem)
                {
                    Assert.IsTrue(Steps.ChekMenuElement(item.Name), "Problem in " + journal.Name);
                }

            }
           

            // Assert.True(Steps.ChekMenuElement(menuName));
        }

        [TestFixtureTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }

    public class TestCasesProvider
    {
        public static IEnumerable TestCases()
        {
            List<Journal> list = ExcelWorker.GetJournals();
            
            foreach (var journal in list)
            {
                yield return new TestCaseData(journal);
            }
            
        }

    }


}