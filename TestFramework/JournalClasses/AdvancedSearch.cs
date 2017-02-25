using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace TestFramework.JournalClasses
{
    public class AdvancedSearch
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("abstract")]
        public string Abstract { get; set; }

        [XmlElement("fullText")]
        public string FullText { get; set; }

        [XmlElement("volume")]
        public string Volume { get; set; }

        [XmlElement("issue")]
        public string Issue { get; set; }

        public AdvancedSearch()
        {

        }
        public AdvancedSearch(string title, string author, string _abstract, string fullText, string volume, string issue)
        {
            this.Title = title;
            this.Author = author;
            this.Abstract = _abstract;
            this.FullText = fullText;
            this.Volume = volume;
            this.Issue = issue;
        }
        public static AdvancedSearch Deserialize(string filePath)
        {
            var advancedSearchSerializer = new XmlSerializer(typeof(AdvancedSearch));
            return (AdvancedSearch)advancedSearchSerializer.Deserialize(new XmlTextReader(filePath));
        }

    }
}
