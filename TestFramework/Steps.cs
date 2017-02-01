using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestFramework.JournalClasses;

namespace TestFramework
{
    public class Steps
    {
        public static void OpenJournal(string journ,bool refreshPage)
        {
            
            if (refreshPage)
            {
                WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/" + journ);
            }
            else if ("http://journals.lww.com/" + journ + "/pages/default.aspx" != WebDriver.Driver.Url)
            {
                WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/" + journ);
            }
        }
        public void ChekJournal()
        {

        }
    }
}
