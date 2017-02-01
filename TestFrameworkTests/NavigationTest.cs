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

namespace TestFrameworkTests
{
    [TestFixture()]
    class NavigationTest
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCases")]
        public void TestMethod(string journalName, string menuName)
        {
            
            Steps.OpenJournal(journalName,false);
            
            Assert.True(MenuElement.IsContainMenuElement(menuName));
        }
    }

    public class TestCasesProvider
    {
        public static List<TestCaseData> TestCases()
        {
            List<Journal> list = ExcelWorker.GetJournals();
            var testCases = new List<TestCaseData>();
            foreach (var journal in list)
            {
                foreach (Menu menu in journal.nav.menu)
                {
                    testCases.Add(new TestCaseData(journal.Name, menu.Name));
                    foreach (MenuItem menuItem in menu.menuItem)
                        testCases.Add( new TestCaseData(journal.Name, menuItem.Name));
                }
            }
            return testCases;
        }
        
    }


}
