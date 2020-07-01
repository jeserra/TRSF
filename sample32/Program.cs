using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

using static System.Console;

namespace sample32
{
    class Program
    {


       /* private static string file1 = @"C:\Users\Lenovo User\Documents\TRSF\1000000 Sales Records1.csv";
        private static  string file2 = @"C:\Users\Lenovo User\Documents\TRSF\1000000 Sales Records2.csv";
        private static  string file3 = @"C:\Users\Lenovo User\Documents\TRSF\1000000 Sales Records3.csv"; */
        
        private static string file1 = @"C:\Users\Lenovo User\Documents\TRSF\beers-cleaned1.csv";
        private static  string file2 = @"C:\Users\Lenovo User\Documents\TRSF\beers-cleaned2.csv";
        private static  string file3 = @"C:\Users\Lenovo User\Documents\TRSF\beers-cleaned3.csv";  


    static async Task Main(string[] args)
    {
     //   ReadSync();
        ReadAsync();
        await ProcessFile();
     }


    static async Task ProcessFile ()
    {
        var result =  await File.ReadAllLinesAsync(file1);
    }

    static void ReadSync()
    {
        
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        
       int result1 = ReadFileSync(file1);
       
       var result2 = ReadFileSync(file2);
       
       var result3 = ReadFileSync(file3);

       stopWatch.Stop();
       TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);

       Console.WriteLine($"{file1}  {result1}");
       Console.WriteLine($"{file2}  {result2}");
       Console.WriteLine($"{file3}  {result3}");
       
    }


    static void ReadAsync()
    {
        
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        
       var TaskRead =   ReadFile(file1);
       
       var TaskRead2 = ReadFile(file2);
       
       var TaskRead3= ReadFile(file3);

       Task.WaitAll(TaskRead, TaskRead2, TaskRead3);

       stopWatch.Stop();
       TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);

       Console.WriteLine($"{file1} {TaskRead.Result}");
       Console.WriteLine($"{file2} {TaskRead2.Result}");
       Console.WriteLine($"{file3} {TaskRead3.Result}");
       
    }

        static async Task<int> ReadFile(string file)  
        {  
            int length = 0;  
    
            Console.WriteLine($" File {file} reading is stating");  
            using (StreamReader reader = new StreamReader(file))  
            {  
                // Reads all characters from the current position to the end of the stream asynchronously    
                // and returns them as one string.    
                string s = await reader.ReadToEndAsync().ConfigureAwait(false);  
    
                length = s.Length;  
            }  
            Console.WriteLine($" File {file} reading is completed");  
            return length;  
        }

            static int ReadFileSync(string file)  
        {  
            int length = 0;  
    
            Console.WriteLine($" File {file} reading is stating");  
            using (StreamReader reader = new StreamReader(file))  
            {  
                // Reads all characters from the current position to the end of the stream asynchronously    
                // and returns them as one string.    
                string s = reader.ReadToEnd();  
    
                length = s.Length;  
            }  
            Console.WriteLine($" File {file} reading is completed");  
            return length;  
        }


    }
}
