using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.WD;

namespace TestFramework.JournalPageObjects
{
    public class MainPage
    {
        public LoginForm LoginForm = new LoginForm();
        public SearchPanel SearchPanel = new SearchPanel();

        public void NavigateHere()
        {
            WebDriver.Driver.Navigate().GoToUrl(TestData.URL);
        }

    }
}
