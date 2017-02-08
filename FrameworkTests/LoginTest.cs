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
        private Steps steps = new Steps();

        [Test, TestCaseSource(typeof(LoginTestCasesProvider), "GetTestCases")]
        public void PossitiveLoginTest(string login, string password)
        {
            steps.LoginWKJournal(login,password);
            
            
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }
    }




    public class LoginTestCasesProvider
    {
        public static IEnumerable<TestCaseData> GetTestCases()
        {
            yield return new TestCaseData("Valiantsin", "lopan2017");
            yield return new TestCaseData("volya218@tut.by", "lopan2017");

        }

    }
}
