using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestFramework.JournalPageObjects;
using TestFramework.Utils;
using System.IO;



namespace TestFramework.Tests
{
    [TestFixture()]
    public class LoginTest
    {
        [Test,TestCaseSource(typeof(LoginTestCasesProvider), " GetTestCase")]
        public void PossitiveLoginTest(string login, string password)
        {
            WD.WebDriver.Driver.Navigate().GoToUrl(TestData.URL);
            LoginForm.Login(login,password);

        }
    }








    class LoginTestCasesProvider
    {
        public static IEnumerable <TestCaseData> GetTestCases()
        {
            yield return new TestCaseData("Valiantsin", "lopan2017");
            yield return new TestCaseData("volya218@tut,by", "lopan2017");

        }

    }
}
