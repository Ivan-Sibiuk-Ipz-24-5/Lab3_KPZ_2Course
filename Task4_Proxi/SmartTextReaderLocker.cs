using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4_Proxi
{
    public class SmartTextReaderLocker
    {
        private SmartTextReader _reader;
        private Regex _restrictedPattern;

        public SmartTextReaderLocker(SmartTextReader reader, string restrictedRegex)
        {
            _reader = reader;
            _restrictedPattern = new Regex(restrictedRegex);
        }

        public char[][] Read()
        {
            if (_restrictedPattern.IsMatch(_readerFilePath()))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            return _reader.Read();
        }

        private string _readerFilePath()
        {
            // використано reflection для отримання _filePath (бо приватне)
            var field = typeof(SmartTextReader).GetField("_filePath", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return field.GetValue(_reader).ToString();
        }
    }
}
