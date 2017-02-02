using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestFramework.JournalClasses;
using TestFramework.JournalPageObjects;

namespace TestFramework
{
    public class Steps
    {
        public static void OpenJournal(string journName)
        {
            WebDriver.Driver.Navigate().GoToUrl(TestData.URL+journName);   
        }
        public static bool ChekMenuElement(string name)
        {
            return MenuElement.IsContainMenuElement(name);
        }
    }
}
