using System;
using System.Collections.Generic;
using sample29.Interfaces;
using static System.Console;
namespace sample29.Implementation
{
    public class ProcessData : IProcessData
    {
        IWriteFile writer ;
        IReadFile reader ;

        public ProcessData (IWriteFile _writer, IReadFile _reader)
        {
            this.writer = _writer;
            this.reader = _reader;
        }

        public void Process (String FileName)
        {
            var inputData = reader.ReadFile(FileName);
            var processedData = Process(inputData);
            writer.WriteToFile( processedData, "salida.txt");
        }

        public List<string> Process(List<string> data)
        {
             WriteLine("Procesando datos ... ");
             data.Reverse();
             return data;
        }
    }
}