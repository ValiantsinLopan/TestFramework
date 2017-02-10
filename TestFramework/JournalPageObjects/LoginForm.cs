using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using TestFramework.WD;

namespace TestFramework.JournalPageObjects
{
    public class LoginForm
    {   
        private const string LoginInputXPath = "//*[contains(@id, 'txt_UserName')]";

        private const string PasswordInputXPath = "//*[contains(@id, 'txt_Password')]";

        private const string LoginButtonXPath = "//*[contains(@id, 'LoginButton')]" ;

        public const string LogoutButtonXPath = "//*[contains(@id, 'Logout')]";

        private const string RememberMeCheckBox = "//*[contains(@id, 'RememberUsername')]";

    

        public void Login(string login, string password)
        {
            WebDriver.Driver.FindElement(By.XPath(LoginInputXPath)).SendKeys(login);
            WebDriver.Driver.FindElement(By.XPath(PasswordInputXPath)).SendKeys(password);
            WebDriver.Driver.FindElement(By.XPath(LoginButtonXPath)).Click();
        }

        public void LoginRememberMe(string login, string password)
        {
            WebDriver.Driver.FindElement(By.XPath(LoginInputXPath)).SendKeys(login);
            WebDriver.Driver.FindElement(By.XPath(PasswordInputXPath)).SendKeys(password);
            WebDriver.Driver.FindElement(By.XPath(RememberMeCheckBox)).Click();
            WebDriver.Driver.FindElement(By.XPath(LoginButtonXPath)).Click();
        }

        public  bool ContainLogout()
        {
            bool contain;
            contain = (WebDriver.Driver.FindElement(By.XPath(LogoutButtonXPath)).Displayed) ? true : false;
            return contain;
        }

        public void Logout()
        {
            WebDriver.Driver.FindElement(By.XPath(LogoutButtonXPath)).Click();
        }

        public string LoginInputText()
        {
            string text = WebDriver.Driver.FindElement(By.XPath(LoginInputXPath)).GetAttribute("value");
            Console.WriteLine(text);
            return text;
        }
    }
}
