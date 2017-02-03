using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace TestFramework.JournalPageObjects
{
    public class LoginForm
    {
        [FindsBy(How=How.XPath, Using = "//*[contains(@id, 'txt_UserName')]")]
        private IWebElement LoginInput;

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'txt_Password')]")]
        private IWebElement PasswordInput;

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'LoginButton')]")]
        private IWebElement LoginButton;

        [FindsBy(How =How.XPath, Using = "//*[contains(@id, 'RememberUsername')]")]
        private IWebElement RememberMeCheckBox;

        public LoginForm()
        {

        }

        public void Login(string login, string password)
        {
            LoginInput.SendKeys(login);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
        }
        public void NavigateHere()
        {
            WD.WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/pages/default.aspx");
        }
    }
}
