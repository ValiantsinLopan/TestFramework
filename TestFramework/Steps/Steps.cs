using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestFramework.JournalClasses;

using TestFramework.WD;
using TestFramework.JournalPageObjects;

namespace TestFramework.Steps
{
    public class Steps
    {
        public void OpenJournal(string journName)
        {
            WD.WebDriver.Driver.Navigate().GoToUrl(TestData.URL+journName);   
        }


        public void LoginWKJournal(string username, string password)
        {
            LoginForm loginForm = new LoginForm(WebDriver.Driver);
            WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/");
            loginForm.Login(username, password);
        }

        public void CloseBrowser()
        {
            WebDriver.KillDriver();
        }
        public static bool ChekMenuElement(string name)
        {
            return MenuElement.IsContainMenuElement(name);
        }
    }
}
