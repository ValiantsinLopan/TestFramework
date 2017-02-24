using System;
using NUnit.Framework;
using TestFramework.WD;
using TestFramework.Steps;
using TestFramework.JournalPageObjects;
using TestFramework.JournalClasses;
using TestFramework.Utils;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using TestFramework.Settings;
using FrameworkTests.DataProviders;


namespace FrameworkTests
{
    [TestFixture()]
    public class LoginXML
    {
        private Step steps = new Step();

        [Test, TestCaseSource(typeof(LoginData), "Possitive")]
        public void XMLPossitiveLoginTest(string username,string password)
        {
            steps.OpenMainPage();
            steps.LoginWKJournal(username, password);
            Assert.IsTrue(steps.IsLogin(), "Login failed");
        }

        [Test, TestCaseSource(typeof(LoginData), "Negative")]
        public void XMLNegativeLoginTest(string username, string password)
        {
            steps.OpenMainPage();
            steps.LoginWKJournal(username, password);
            Assert.IsTrue(steps.NotLogin(), "Login failed");
        }
        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }
    }
}
