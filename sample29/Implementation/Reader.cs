using System;
using sample29.Interfaces;
using System.Collections.Generic;
using static System.Console;

namespace sample29.Implementation
{
    public class Reader : IReadFile
    {
        public List<string> ReadFile(string FileName)
        {
            var array = System.IO.File.ReadAllLines(FileName);
            List<String> result = new List<string>(array);

            WriteLine("Leyo el archivo");
            return result;
        }
    }
}