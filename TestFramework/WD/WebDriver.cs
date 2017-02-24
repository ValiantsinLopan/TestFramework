using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using TestFramework.Settings;



namespace TestFramework.WD
{
    public class WebDriver
    {
        private WebDriver() { }

        private static IWebDriver driver;
        

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                
                    driver = new WDGetter().GetDriver(SettingsBrowser.Default.Chrome);
                    return driver;
            }
        }
       
        

        public static void KillDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
