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

namespace TestFramework.WD
{
    public  class WDGetter
    {
        private static IWebDriver driver;
        public const string Chrome = "chrome";
        public const string FireFox = "firefox";
        public const string Edge = "Edge";
        public const string IE = "IE";

        public IWebDriver GetDriver(string browser)
        {
            switch (browser)
            {
                case Chrome:
                    {
                        return GetChromeDriver();
                    }
                case FireFox:
                    {
                        return GetFireFoxDriver();
                    }

                case Edge:
                    {
                        return GetEdgeDriver();
                    }

                case IE:
                    {
                        return GetIEDriver();
                    }

                default:
                    {
                        break; ;
                    }
            }

            throw new NotFoundException();
        }
        public static IWebDriver GetChromeDriver()
        {
            driver = new ChromeDriver(TestData.DriverPathSony);
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static IWebDriver GetFireFoxDriver()
        {
            driver = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(TestData.DriverPathFireFox));
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static IWebDriver GetEdgeDriver()
        {
            driver = new EdgeDriver(TestData.DriverPathEdge);
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static IWebDriver GetIEDriver()
        {
            driver = new InternetExplorerDriver(TestData.DriverPathIE);
            driver.Manage().Window.Maximize();
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

    }
}
