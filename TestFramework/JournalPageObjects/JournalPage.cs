using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestFramework.JournalClasses;

namespace TestFramework.JournalPageObjects
{
    public class JournalPage
    {
        public IWebElement DropdownMenu { get { return WebDriver.Driver.FindElement(By.XPath()); } }
        public IWebElement DropdownMenuItem { get { return WebDriver.Driver.FindElement(By.XPath()); } }
        public IWebElement StaticMenu { get { return WebDriver.Driver.FindElement(By.XPath()); } }
        public JournalPage()
        {

        }
        public void NavigateHere()
        {
            WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/"+Journal.GetURL());
        }
    }
}
