using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.WD;
using OpenQA.Selenium;
using System.Configuration;

namespace TestFramework.JournalPageObjects
{
    public class JournalPage
    {
        private string url;

        public SearchPanel SearchPanel = new SearchPanel();
        public LoginForm LoginForm = new LoginForm();

        private const string CurrentIssueXPath = "//*[contains(@id, 'CurrentIssueContainer')]/a";
        //private const string FirstArticleXPath = "//*[contains(@id, 'itemListContainer')]/article[1]/div/div/header/h4/a";
        private const string FirstArticleXPath = "//*/article[1]/div/div/header/h4/a";

        public string Url
        {
            get { return url; }

            set { url = $"{ TestData.URL}/{value}"; }

        }

        public void NavigateHere(string journalName)
        {
            WebDriver.Driver.Navigate().GoToUrl($"{TestData.URL}/{journalName}/");
        }

        public void NavigateCurrentIssuePage(string journalName)
        {
            WebDriver.Driver.Navigate().GoToUrl($"{TestData.URL}/{journalName}/Pages/currenttoc.aspx");
        }

        public string GetArticleName()
        {
            return WebDriver.Driver.FindElement(By.XPath(FirstArticleXPath)).GetAttribute("text");
        }
         
    }
}