using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.WD;

namespace TestFramework.JournalPageObjects
{
    public class JournalPage
    {
        private string url;

        public SearchPanel SearchPanel = new SearchPanel();
        public LoginForm LoginForm = new LoginForm();

        public string Url
        {
            get { return url; }

            set { url = $"{ TestData.URL}/{value}"; }

        }

        public void NavigateHere(string joutnalName)
        {
            WebDriver.Driver.Navigate().GoToUrl(Url);
        }

    }
}
