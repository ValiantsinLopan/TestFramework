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
        private static IWebElement LoginInput;

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'txt_Password')]")]
        private static IWebElement PasswordInput;

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'LoginButton')]")]
        private static IWebElement LoginButton;

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'Logout')]")]
        private IWebElement LogoutButton;

        [FindsBy(How =How.XPath, Using = "//*[contains(@id, 'RememberUsername')]")]
        private IWebElement RememberMeCheckBox;

        public LoginForm()
        {

        }

        public static void Login(string login, string password)
        {
            LoginInput.SendKeys(login);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
        }

        public void Logout()
        {
            LogoutButton.Click();
        }

        public void NavigateHere()
        {
            WD.WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/pages/default.aspx");
        }
    }
}
