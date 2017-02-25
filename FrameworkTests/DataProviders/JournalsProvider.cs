using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestFramework.JournalClasses;
using TestFramework;
using TestFramework.JournalPageObjects;
using TestFramework.Utils;
using TestFramework.WD;
using TestFramework.Steps;

namespace FrameworkTests.DataProviders
{
    public class JournalsProvider
    {
        public static IEnumerable GetJournals()
        {
            List<Journal> list = ExcelWorker.GetJournals(6);
            foreach(Journal journal in list)
            {
                yield return new TestCaseData(journal);
            }
        }
    }
}
