using System;
using NUnit.Framework;
using TestFramework.WD;
using TestFramework.Steps;
using TestFramework.JournalPageObjects;
using TestFramework.JournalClasses;
using TestFramework.Utils;
using System.IO;
using System.Collections.Generic;

namespace FrameworkTests
{
    [TestFixture()]
    public class SearchTest
    {
        private SearchSteps steps = new SearchSteps();
        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCases")]
        public void SearchArticleInJournalTest(Journal journal)
        {
            steps.OpenJournal(journal.Name);
            steps.SearchArticleFromIsuue();
            Assert.IsTrue(steps.IsFound(),"Article not found");

        }

        [TearDown]
        public void CleanUp()
        {
            steps.CloseBrowser();
        }
    }
}
