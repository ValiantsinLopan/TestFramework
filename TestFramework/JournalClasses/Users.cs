using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TestFramework.JournalClasses
{
    [Serializable]
    public class Users
    {
        [XmlElement("user")]
        public List<Login> users { get; set; }

        public static Users Deserialize(string filePath)
        {
            var usersSerializer = new XmlSerializer(typeof(Users));
            return (Users)usersSerializer.Deserialize(new XmlTextReader(filePath));
        }
    }
}
