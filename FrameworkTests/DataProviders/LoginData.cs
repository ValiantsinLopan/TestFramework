using System;
using NUnit.Framework;
using TestFramework.JournalClasses;
using System.Collections;
using FrameworkTests.Settings;


namespace FrameworkTests.DataProviders
{
    public class LoginData
    {
        public static IEnumerable Possitive()
        {
            var data = Users.Deserialize(SettingsPaths.Default.positiveSony);
            foreach (Login currentUser in data.users)
            {
                yield return new TestCaseData(currentUser.userName, currentUser.password);
            }

        }
        public static IEnumerable Negative()
        {
            var data = Users.Deserialize(SettingsPaths.Default.NegativeLoginData);
            foreach (Login currentUser in data.users)
            {
                yield return new TestCaseData(currentUser.userName, currentUser.password);
            }

        }
    }
}
