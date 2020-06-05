using System;

namespace sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre primer valor");
            var input1  = Console.ReadLine();
         //   Console.WriteLine (input1);
            Console.WriteLine("Entre segundo valor");
           var input2  = Console.ReadLine();
            var result = int.Parse(input1) + int.Parse(input2);
           Console.WriteLine(result);
           Console.ReadKey();

        }
    }
}
