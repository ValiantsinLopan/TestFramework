using System;
using NUnit.Framework;
using TestFramework.WD;
using TestFramework.Steps;
using TestFramework.JournalPageObjects;
using TestFramework.JournalClasses;
using TestFramework.Utils;
using System.IO;
using System.Collections.Generic;



namespace FrameworkTests
{
    [TestFixture()]
    public class LoginTest
    {
        private Step steps = new Step();

        [Test, TestCaseSource(typeof(TestCasesFromFile), "PossitiveTestData")]
        public void PossitiveLoginTest(Login user)
        {
            steps.OpenMainPage();
            steps.LoginWKJournal(user.userName,user.password);
            Assert.IsTrue(steps.IsLogin(), "Login failed");
        }

        [Test, TestCaseSource(typeof(TestCasesFromFile), "NegativeTestData")]
        public void NegativeLoginTest(Login user)
        {
            steps.OpenMainPage();
            steps.LoginWKJournal(user.userName, user.password);
            Assert.IsFalse(steps.IsLogin(), "Login failed");
        }
        [Test, TestCaseSource(typeof(TestCasesFromFile), "PossitiveTestData")]
        public void RememberUserTest(Login user)
        {
            steps.OpenMainPage();
            Assert.IsTrue(steps.IsRememberUser(user.userName,user.password), "Login failed");
        }


        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }
    }

    public class TestCasesFromFile
    {
        public static IEnumerable<TestCaseData> PossitiveTestData()
        { 
            List<Login> users = ExcelWorker.GetUserlist(@"C:\Users\Valiantsin_Lopan\Documents\Visual Studio 2015\Projects\TestFramework\TestFramework\TestData\PossitiveLoginData.xlsx");
            foreach (var user in users)
            {
                 yield return new TestCaseData(user);
            }
            
        }

        public static IEnumerable<TestCaseData> NegativeTestData()
        {
            List<Login> users = ExcelWorker.GetUserlist(@"C:\Users\Valiantsin_Lopan\Documents\Visual Studio 2015\Projects\TestFramework\TestFramework\TestData\NegativeLoginData.xlsx");
            foreach (var user in users)
            {
                yield return new TestCaseData(user);
            }

        }
    }
}
