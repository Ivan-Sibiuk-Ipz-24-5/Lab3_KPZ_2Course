using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1_Adapter
{
    public class FileWriter
    {
        private string _path;

        public FileWriter(string path)
        {
            _path = path;
        }

        public void Write(string message)
        {
            File.AppendAllText(_path, message);
        }

        public void WriteLine(string message)
        {
            File.AppendAllText(_path, message + "\n");
        }
    }
}