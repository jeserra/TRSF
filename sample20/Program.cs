using System;
using System.IO;
using System.Text;

namespace sample20
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Testing 1-2-3 \\n ñ @";
 
            // convert string to stream
            byte[] byteArray = Encoding.ASCII.GetBytes( test );
            MemoryStream stream = new MemoryStream( byteArray ); 
 
            // convert stream to string
            StreamReader reader = new StreamReader( stream );
            string text = reader.ReadToEnd();
 
            Console.WriteLine( text );
            Console.ReadLine();

        }
    }
}
