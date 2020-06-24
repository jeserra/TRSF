using System;
using System.Collections.Generic;
using sample29.Interfaces;
using static System.Console;

namespace sample29.Implementation
{
    public class Writer : IWriteFile
    {
        public void WriteToFile(List<string> data, string file)
        {
            WriteLine("Escribiendo Datos ...");
            System.IO.File.WriteAllLines(file, data);
        }
    }
}