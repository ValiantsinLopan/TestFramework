using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestFramework.JournalClasses;
using TestFramework;

namespace TestFrameworkTests
{
    [TestFixture()]
    class NavigationTest
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCases")]
        public void TestMethod(string data)
        {
            System.Console.WriteLine(data);
            Assert.IsTrue(true);
        }
    }

    public class TestCasesProvider
    {
        public static IEnumerable TestCases()
        {
            List<Journal> list = ExcelWorker.GetJournals();

            foreach (var journal in list)
            {
                yield return new TestCaseData(journal.Name);
            }
        }
    }
}
