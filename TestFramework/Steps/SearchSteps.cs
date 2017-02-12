using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.WD;
using TestFramework.JournalPageObjects;

namespace TestFramework.Steps
{
    public class SearchSteps
    {
        JournalPage JournalPage = new JournalPage();
        SearchResultPage SearchResultPage = new SearchResultPage();

        public void OpenJournal(string journalName)
        {
            JournalPage.NavigateHere(journalName);
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
    }
}
