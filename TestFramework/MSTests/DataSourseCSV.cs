using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Utils;


namespace TestFramework.MSTests
{
    public class DataSourseCSV
    {
        public static void GetTestCaseData(int batchNumber)
        {
            var journals = ExcelWorker.GetJournals(batchNumber);
            CsvWorker.WriteRow(TestData.DataForMStestDataSource, "Journal,MenuItem\n");
            foreach(var journal in journals)
            {
                foreach(var menu in journal.nav.menu)
                {
                    CsvWorker.WriteRow(TestData.DataForMStestDataSource, CsvWorker.AddSepatator(journal.Name, menu.Name));
                    foreach(var menuIten in menu.menuItem)
                    {
                        CsvWorker.WriteRow(TestData.DataForMStestDataSource, CsvWorker.AddSepatator(journal.Name, menuIten.Name));
                    }

                }
                
            }

        }
    }

}
