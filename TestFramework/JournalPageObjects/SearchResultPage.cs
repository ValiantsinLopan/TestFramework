using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestFramework.WD;

namespace TestFramework.JournalPageObjects
{
    public class SearchResultPage
    {
        SearchPanel SearchPanel = new SearchPanel();

        private const string YouSearchedForXPAth = "//*[contains(@id, 'userKeyWords')]/b";

        public bool IsFoundResults()
        {
            if (WebDriver.Driver.FindElement(By.XPath(YouSearchedForXPAth)).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
