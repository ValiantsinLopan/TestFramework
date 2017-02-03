using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TestFramework.JournalClasses;
using TestFramework;
using TestFramework.JournalPageObjects;
using TestFramework.WD;
namespace TestFrameworkTests1
{
    [TestFixture]
    public class TestXPath
    {
        public IWebElement Menu { get { return WebDriver.Driver.FindElement(By.XPath("//div[@id='zz1_TopNavigationMenu']//*[text()='Articles & Issues']")); } }
        [Test]
        public void XPath()
        {
            string jourName = "menopausejournal";
            Steps.OpenJournal(jourName);
            Menu.Click();


        }
    }
}
