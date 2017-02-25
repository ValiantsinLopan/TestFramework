using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.WD;
using TestFramework.JournalPageObjects;
using OpenQA.Selenium;

namespace TestFramework.Steps
{
    public class SearchSteps
    {
        JournalPage JournalPage = new JournalPage();
        SearchResultPage SearchResultPage = new SearchResultPage();
        AdvancedSearchPage AdvancedSearchPage = new AdvancedSearchPage();
        public void OpenJournal(string journalName)
        {
            JournalPage.NavigateHere(journalName);
        }

        public void OpenCurrentIssueJournalPage(string journalName)
        {
            JournalPage.NavigateCurrentIssuePage(journalName);
        }

        public void SearchArticleFromIsuue()
        {
            string request = JournalPage.GetArticleName();
            JournalPage.SearchPanel.Search(request);
        }
        public bool IsFound()
        {
            return SearchResultPage.IsFoundResults();
        }
        public void CloseBrowser()
        {
            WebDriver.KillDriver();
        }
        public void OpenAdvancedSearchPageInCurrentJournal(string journalName)
        {
            AdvancedSearchPage.NavigateAdvancedSearchPage(journalName);
        }
        public void AdvancedSearchByKeywords(string request, int textBoxNumber)
        {
            IWebElement keywordInput = AdvancedSearchPage.KeywordInput(textBoxNumber);
            AdvancedSearchPage.EnterRequestToKeywordInput(request,keywordInput);
        }
    }
}
