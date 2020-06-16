using System;
using System.IO;
using System.Threading.Tasks;
namespace sample19
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string filename = @"C:\Users\Lenovo User\Documents\TRSF\prueba.txt"; 
            string EndDirectory = @"C:\Users\Lenovo User\Documents\TRSF\salida.txt"; 
 
            using (FileStream SourceStream = File.Open(filename, FileMode.Open)) 
            { 
                using (FileStream DestinationStream = File.Create(EndDirectory)) 
                { 
                    await SourceStream.CopyToAsync(DestinationStream); 
                } 
            } 
        }
    }
}
