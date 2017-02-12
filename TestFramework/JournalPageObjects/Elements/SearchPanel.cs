using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestFramework.WD;

namespace TestFramework.JournalPageObjects
{
    public class SearchPanel
    {
        private const string SearchBoxXPath = "//*[contains(@id, 'SearchBox')]";

        private const string SearchButtonXPath = "//*[@id='btnGlobalSearchMagnifier']";

        public void Search(string request)
        {
            WebDriver.Driver.FindElement(By.XPath(SearchBoxXPath)).SendKeys(request);
            WebDriver.Driver.FindElement(By.XPath(SearchButtonXPath)).Click();
        }
    }
}
