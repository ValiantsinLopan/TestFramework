using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestFramework.JournalClasses
{
    public class Login
    {
        [XmlElement("username")]
        public string userName { get; set; }

        [XmlElement("password")]
        public string password { get; set; }

        public Login()
        {

        }
        public Login(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
