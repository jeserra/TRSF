using System;
using System.Collections.Generic;

namespace sample14
{
    class Program
    { 

        static void Main(string[] args)
        {
            int [] array = new int[3];
            string [] strarray = new string[3];

            array[0] = 10;
            array[2] = 20;
            array[1] = 5;
            Sortear(ref array);

            strarray [0] = "uno";
                  strarray [1] = "dos";
                  strarray [2] = "tres";

            Sortear(ref strarray);

            List<int> arrayint = new List<int>();
            arrayint.Add(10);
            arrayint.Add(30);
            arrayint.Add(14);
            arrayint.Sort();
            var count =  arrayint.Count;
            arrayint.Clear();


            List<string> listStr = new List<string>();
            listStr.Add("uno");
            listStr.Add("dos");
            listStr.Add("tres");

            listStr.Sort();
        }


        static void Sortear (ref int[] array)
        {
            for (int i = 0; i<= array.Length -1; i++)
                Console.WriteLine($"{array[i]}" );
        }

        static void Sortear (ref string [] array )
        {
             for (int i = 0; i<= array.Length -1; i++)
                Console.WriteLine($"{array[i]}" );
        }

    }
}
