using System;
using NUnit.Framework;
using TestFramework.WD;
using TestFramework.Steps;
using TestFramework.JournalPageObjects;
using System.IO;
using System.Collections.Generic;


namespace FrameworkTests
{
    [TestFixture()]
    public class LoginTest
    {
        private Step steps = new Step();

        [Test, TestCaseSource(typeof(LoginTestCasesProvider), "PossitiveTestData")]
        public void PossitiveLoginTest(string login, string password)
        {
            steps.OpenMainPage();
            steps.LoginWKJournal(login,password);
            Assert.IsTrue(steps.IsLogin(), "Login failed");
        }

        [Test, TestCaseSource(typeof(LoginTestCasesProvider), "NegativeTestData")]
        public void NegativeLoginTest(string login, string password)
        {
            steps.OpenMainPage();
            steps.LoginWKJournal(login, password);
            Assert.IsFalse(steps.IsLogin(), "Login failed");
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }
    }




    public class LoginTestCasesProvider
    {
        public static IEnumerable<TestCaseData> PossitiveTestData()
        {
            yield return new TestCaseData("Valiantsin", "lopan2017");
            yield return new TestCaseData("valiantsin", "lopan2017");
            yield return new TestCaseData("volya218@tut.by", "lopan2017");
            
        }

        public static IEnumerable<TestCaseData> NegativeTestData()
        {
            yield return new TestCaseData("Valiantsin", "lopan");
            yield return new TestCaseData("", "lopan2017");
            yield return new TestCaseData(" volya218@tut.by", "lopan2017");

        }
    }
}
