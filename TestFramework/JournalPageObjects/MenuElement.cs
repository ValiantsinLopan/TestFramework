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

       


        public static bool IsContainMenuElement(string name)
        {
            try
            {
                WD.WebDriver.Driver.FindElement(By.XPath($"//div[@id='zz1_TopNavigationMenu']//*[text()='{name}']"));
                

            }
            catch (WebDriverException)
            {
                return false;
            }
            return true;

        }

   
    }
}
