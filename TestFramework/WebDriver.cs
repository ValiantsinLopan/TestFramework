using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;


namespace TestFramework
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
                {
                    driver = new ChromeDriver(TestData.DriverPath);
                    driver.Manage().Window.Maximize();
                }

                return driver;
            }
        }
        public IWebDriver GetDriver(string browser)
        {
            switch (browser)
            {
                case chrome:
                    return GetChromeDriver();
                    break;
                case firefox:
                    return GetFireFoxDriver();
                    break;
                case edge:
                    return GetEdgeDriver();
                    break;
                 

            }
                

        }
        public IWebDriver GetChromeDriver()
        {
            driver = new ChromeDriver(TestData.DriverPath);
            return driver;
        }

        public IWebDriver GetFireFoxDriver()
        {
            driver = new FirefoxDriver();
            return driver;
        }

        public IWebDriver GetEdgeDriver()
        {
            driver = new EdgeDriver();
            return driver;
        }

        public IWebDriver GetIEDriver()
        {
            driver = new InternetExplorerDriver();
            return driver;
        }
        public IWebDriver GetOperaDriver()
        {
            driver = new OperaDriver();
            return driver;
        }
        public IWebDriver GetSafariDriver()
        {
            driver = new SafariDriver();
            return driver;
        }

        

        public static void KillDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
