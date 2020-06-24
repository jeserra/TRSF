using System;
using System.Collections.Generic;

namespace sample29.Interfaces 
{
    public interface IWriteFile
    {
        void WriteToFile (List<String> data, string File);
    }
}