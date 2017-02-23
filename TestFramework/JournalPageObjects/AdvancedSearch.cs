using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.WD;
using OpenQA.Selenium;

namespace TestFramework.JournalPageObjects
{
    public class AdvancedSearch
    {

        public SearchPanel SearchPanel = new SearchPanel();

        private const string ScopeAllFieldsXPath = ".//*[@id='dplScope_1']";
        private const string ScopeTitleXPath = ".//*[@id='dplScope_2']";
        private const string ScopeAuthorXPath = ".//*[@id='dplScope_3']";
        private const string ScopeAbstractXPath = ".//*[@id='dplScope_4']";
        private const string ScopeFullTextXPath = ".//*[@id='dplScope_5']";
        private const string ScopeVolumeXPath = ".//*[@id='dplScope_6']";
        private const string ScopeIssueXPath = ".//*[@id='dplScope_7']";

        private const string KeywordInput1XPath = ".//*[@id='keywords_input_1']";
        private const string KeywordInput2XPath = ".//*[@id='keywords_input_2']";
        private const string KeywordInput3XPath = ".//*[@id='keywords_input_3']";
        private const string KeywordInput4XPath = ".//*[@id='keywords_input_4']";
        private const string KeywordInput5XPath = ".//*[@id='keywords_input_5']";
        private const string KeywordInput6XPath = ".//*[@id='keywords_input_6']";
        private const string KeywordInput7XPath = ".//*[@id='keywords_input_7']";

        private const string CheckBoxArticlesXPath = ".//*[contains(@id,'filterListArticle')]";
        private const string CheckBoxImagesXPath = ".//*[contains(@id,'filterListImage')]";
        private const string CheckBoxPodcastXPath = ".//*[contains(@id,'filterListPodcast')]";
        private const string CheckBoxVideosXPath = ".//*[contains(@id,'filterListVideo')]";
        private const string CheckBoxBlogsXPath = ".//*[contains(@id,'filterListBlog')]";

        private const string CheckBoxCMEXPath = ".//*[contains(@id,'filterListCME')]";
        private const string CheckBoxSDCXPath = ".//*[contains(@id,'filterListSDC')]";

        private const string RadioButtonAllDates = ".//*[contains(@id,'searchDatesRadioButtonList_0')]";
        private const string RadioButtonCurrentIssue = ".//*[contains(@id,'searchDatesRadioButtonList_1')]";
        private const string RadioButtonLast12Months = ".//*[contains(@id,'searchDatesRadioButtonList_2')]";
        private const string RadioButtonLast3Years = ".//*[contains(@id,'searchDatesRadioButtonList_3')]";
        private const string RadioButtonLast5Years = ".//*[contains(@id,'searchDatesRadioButtonList_4')]";
        private const string RadioButtonLast8Years = ".//*[contains(@id,'searchDatesRadioButtonList_5')]";

        private const string SearchButtonXPath = ".//*[contains(@id,'searchAgain')]";
        private const string ResetButtonXPath = ".//*[@id='Reset']";

        public void NavigateHere(string jouurnalName)
        {
            WebDriver.Driver.Navigate().GoToUrl($"{TestData.URL}/{jouurnalName}/pages/advancedsearch.aspx");
        }
        public void Search(string request)
        {

        }
    }
}
