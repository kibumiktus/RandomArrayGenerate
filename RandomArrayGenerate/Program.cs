using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArrayGenerate
{
    class Program
    {
        private const int defaultSize = 10 * 1000;
        private const string defaultFileNamePattern = "RandomArray-{0}.txt";

        static void Main(string[] args)
        {
            var arrayGenerator = new RandomArrayGenerator(defaultSize);
            var randomArray = arrayGenerator.Generate();

            var resultString = string.Join(",", randomArray);
            var dateTimeToPath = DateTime.Now.ToString("hh-mm-ss dd-MM-yyyy");
            var fileName = string.Format(defaultFileNamePattern, dateTimeToPath);

            File.WriteAllText(fileName, resultString);
        }
    }
}
