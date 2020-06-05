using System;

namespace sample3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2147483647; 
                      
            long bigNum = num;
 
            bigNum = long.MaxValue;
            //num = bigNum;
  
            num = (int)bigNum;
            Console.WriteLine(num);
            Console.Read();

        }
    }
}
