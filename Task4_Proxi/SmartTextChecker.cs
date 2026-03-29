using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Proxi
{
    public class SmartTextChecker
    {
        private SmartTextReader _reader;

        public SmartTextChecker(SmartTextReader reader)
        {
            _reader = reader;
        }

        public char[][] Read()
        {
            Console.WriteLine("Opening file...");
            char[][] data = _reader.Read();
            Console.WriteLine("File read successfully!");
            int totalChars = 0;
            foreach (var line in data) totalChars += line.Length;
            Console.WriteLine($"Total lines: {data.Length}, Total characters: {totalChars}");
            Console.WriteLine("Closing file...");
            return data;
        }
    }
}
