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

namespace FrameworkTests
{
    [TestFixture()]
    public class LoginXML
    {
        private Step steps = new Step();

        [Test, TestCaseSource(typeof(TestCasesFromXML), "Possitive")]
        public void XMLPossitiveLoginTest(IDictionary<string, string> parameters)
        {
            steps.OpenMainPage();
            steps.LoginWKJournal(parameters["user"], parameters["password"]);
            Assert.IsTrue(steps.IsLogin(), "Login failed");
        }

        [Test, TestCaseSource(typeof(TestCasesFromXML), "Negative")]
        public void XMLNegativeLoginTest(IDictionary<string, string> parameters)
        {
            steps.OpenMainPage();
            steps.LoginWKJournal(parameters["user"], parameters["password"]);
            Assert.IsTrue(steps.NotLogin(), "Login failed");
        }
        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }
    }



    public class TestCasesFromXML
    {
        public static IEnumerable Possitive
        {
            get { return DataDrivenHelper.ReadDataDriveFile(@"C:\Users\Valiantsin_Lopan\Documents\Visual Studio 2015\Projects\TestFramework\TestFramework\TestData\LoginTestCases.xml", "possitive", new[] { "user", "password" }); }
        }
        public static IEnumerable Negative
        {
            get { return DataDrivenHelper.ReadDataDriveFile(@"C:\Users\Valiantsin_Lopan\Documents\Visual Studio 2015\Projects\TestFramework\TestFramework\TestData\LoginTestCases.xml", "negative", new[] { "user", "password" }); }
        }
    }
}
