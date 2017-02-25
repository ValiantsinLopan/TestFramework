using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.WD;
using OpenQA.Selenium;

namespace TestFramework.JournalPageObjects
{
    public class AdvancedSearchPage
    {
        public SearchPanel SearchPanel = new SearchPanel();
        
        private const string CheckBoxArticlesXPath = ".//*[contains(@id,'filterListArticle')]";
        private const string CheckBoxImagesXPath = ".//*[contains(@id,'filterListImage')]";
        private const string CheckBoxPodcastXPath = ".//*[contains(@id,'filterListPodcast')]";
        private const string CheckBoxVideosXPath = ".//*[contains(@id,'filterListVideo')]";
        private const string CheckBoxBlogsXPath = ".//*[contains(@id,'filterListBlog')]";

        private const string CheckBoxCMEXPath = ".//*[contains(@id,'filterListCME')]";
        private const string CheckBoxSDCXPath = ".//*[contains(@id,'filterListSDC')]";
        
        private const string SearchButtonXPath = ".//*[contains(@id,'searchAgain')]";
        private const string ResetButtonXPath = ".//*[@id='Reset']";
        
        public IWebElement Scope(int number)
        {
            return WebDriver.Driver.FindElement(By.XPath($".//*[@id='dplScope_{number}']"));
        }

        public IWebElement KeywordInput(int number)
        {
            return WebDriver.Driver.FindElement(By.XPath($".//*[@id='keywords_input_{number}']"));
        }

        public IWebElement RadioButton(int number)
        {
            return WebDriver.Driver.FindElement(By.XPath($".//*[contains(@id,'searchDatesRadioButtonList_{number}')]"));
        }
        
        public void NavigateAdvancedSearchPage(string jouurnalName)
        {
            WebDriver.Driver.Navigate().GoToUrl($"{TestData.URL}/{jouurnalName}/pages/advancedsearch.aspx");
        }
        public void EnterRequestToKeywordInput(string request, IWebElement keywordInput)
        {
            keywordInput.SendKeys(request);
            WebDriver.Driver.FindElement(By.XPath(SearchButtonXPath)).Click();
        }
    }
}
