using sample29.Interfaces;
using sample29.Implementation; 
using Microsoft.Extensions.DependencyInjection;

namespace sample29
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriteFile write = new Writer();
            IReadFile read = new Reader();

            var collection = new ServiceCollection();
            collection.AddScoped<IReadFile, Reader>();
            collection.AddScoped<IWriteFile, Writer>();
            collection.AddScoped<IProcessData, ProcessData>();
            var serviceProvider = collection.BuildServiceProvider();
            
            var service =  serviceProvider.GetService(typeof(IProcessData)); 

            ((IProcessData)service).Process(@"C:\Users\Lenovo User\Documents\TRSF\Sesiones\eng.1.csv");
        }
    }
}
