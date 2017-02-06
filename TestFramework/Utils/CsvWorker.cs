using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestFramework.Utils
{
    public class CsvWorker
    {
        public static string AddSepatator(params string [] parameters)
        {
            string separator = ",";
            var input = new StringBuilder();
            for (int i = 0; i < parameters.Length - 1; i++)
            {
                input.Append(parameters[i] + separator);
            }
            input.Append(parameters[parameters.Length - 1]);
            input.Append(Environment.NewLine);
            return input.ToString();
        }

        public static void WriteRow(string path, string row)
        {
            string filePath = $@"{path}\Data.csv";
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, row);
               
            }
            else
            {
                File.AppendAllText(filePath, row);
            }

            
        }
    }

}
