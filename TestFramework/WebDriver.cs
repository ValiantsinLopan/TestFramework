﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
        public void GetDriver(string browser)
        {

        }
        public void GetChromeDriver()
        {

        }




        public static void KillDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
