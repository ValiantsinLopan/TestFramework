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
            Console.WriteLine(journal.Name);
            steps.OpenCurrentIssueJournalPage(journal.Name);
            steps.SearchArticleFromIsuue();
            Assert.True(steps.IsFound(), $"bug in {journal.Name}");

        }

        [TearDown]
        public void CleanUp()
        {
            steps.CloseBrowser();
        }
    }
}
