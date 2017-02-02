using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestFramework.JournalClasses;

namespace TestFramework.JournalPageObjects
{
    public class MenuElement
    {
       
        public  static string XPathForNavigation = "//div[@id='zz1_TopNavigationMenu']";

        public  static string GetMenuName(string menuName)
        {
            string text = "//*[text()='" + menuName + "']";
            return text;
        }


        public static bool IsContainMenuElement(string name)
        {
            try
            {
                WebDriver.Driver.FindElement(By.XPath(XPathForNavigation + GetMenuName(name)));
                

            }
            catch (WebDriverException)
            {
                return false;
            }
            return true;

        }

   
    }
}
