﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestFramework.JournalClasses;

using TestFramework.WD;
using TestFramework.JournalPageObjects;

namespace TestFramework.Steps
{
    public class Step
    {
        private static MainPage MainPage = new MainPage();

        public static void OpenJournal(string journName)
        {
            WebDriver.Driver.Navigate().GoToUrl(TestData.URL+journName);   
        }

        public void OpenMainPage()
        {
            MainPage.NavigateHere();
        }

        public void LoginWKJournal(string username, string password)
        {
            MainPage.LoginForm.Login(username, password);
        }
        public bool IsRememberUser(string username, string password)
        {
            MainPage.LoginForm.LoginRememberMe(username, password);
            MainPage.LoginForm.Logout();
            if (MainPage.LoginForm.LoginInputText() == username)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLogin()
        {
            return MainPage.LoginForm.ContainLogout();
        }

        public bool NotLogin()
        {
            return MainPage.LoginForm.ContainLogin();
        }

        public void CloseBrowser()
        {
            WebDriver.KillDriver();
        }
        
        public static bool ChekMenuElement(string name)
        {
            return MenuElement.IsContainMenuElement(name);
        }
    }
}
