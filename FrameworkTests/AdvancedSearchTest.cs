using System;
using NUnit.Framework;
using TestFramework.WD;
using TestFramework.Steps;
using TestFramework.JournalPageObjects;
using TestFramework.JournalClasses;
using TestFramework.Utils;
using System.IO;
using System.Collections.Generic;
using FrameworkTests.DataProviders;
using FrameworkTests.Settings;


namespace FrameworkTests
{
    [TestFixture()]
    public class AdvancedSearchTest
    {
        private SearchSteps steps = new SearchSteps();
        public static AdvancedSearch data;  
        [OneTimeSetUp]
        public void GetAdvancedSearchData()
        {
            data = AdvancedSearch.Deserialize(SettingsPaths.Default.AdvancedSearchData);
        }
            
        [Test,TestCaseSource(typeof(JournalsProvider), "GetJournals")]
        public void SearchByAllFields(Journal journal)
        {
            steps.OpenAdvancedSearchPageInCurrentJournal(journal.Name);
            steps.AdvancedSearchByKeywords(journal.Name,1);

            Assert.True(steps.IsFound(), $"bug in {journal.Name}");

        }
        
        [Test, TestCaseSource(typeof(JournalsProvider), "GetJournals")]
        public void SearchByTitle(Journal journal)
        {
            steps.OpenAdvancedSearchPageInCurrentJournal(journal.Name);
            steps.AdvancedSearchByKeywords(data.Title,2);

            Assert.True(steps.IsFound(), $"bug in {journal.Name}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "GetJournals")]
        public void SearchByAuthor(Journal journal)
        {
            steps.OpenAdvancedSearchPageInCurrentJournal(journal.Name);
            steps.AdvancedSearchByKeywords(data.Author, 3);

            Assert.True(steps.IsFound(), $"bug in {journal.Name}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "GetJournals")]
        public void SearchByAbstract(Journal journal)
        {
            steps.OpenAdvancedSearchPageInCurrentJournal(journal.Name);
            steps.AdvancedSearchByKeywords(data.Abstract, 4);

            Assert.True(steps.IsFound(), $"bug in {journal.Name}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "GetJournals")]
        public void SearchByFullText(Journal journal)
        {
            steps.OpenAdvancedSearchPageInCurrentJournal(journal.Name);
            steps.AdvancedSearchByKeywords(data.FullText, 5);

            Assert.True(steps.IsFound(), $"bug in {journal.Name}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "GetJournals")]
        public void SearchByVolume(Journal journal)
        {
            steps.OpenAdvancedSearchPageInCurrentJournal(journal.Name);
            steps.AdvancedSearchByKeywords(data.Volume, 6);

            Assert.True(steps.IsFound(), $"bug in {journal.Name}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "GetJournals")]
        public void SearchByIssue(Journal journal)
        {
            steps.OpenAdvancedSearchPageInCurrentJournal(journal.Name);
            steps.AdvancedSearchByKeywords(data.Issue, 7);

            Assert.True(steps.IsFound(), $"bug in {journal.Name}");
        }

        [TearDown]
        public void CleanUp()
        {
            steps.CloseBrowser();
        }
    }
}
