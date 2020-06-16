using System;
using System.Collections.Generic;
namespace sample16
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> listado = new  Dictionary<int, string>();
            listado.Add(7, "Messi");
            listado.Add(9, "Luis Suarez");
            if(  listado.TryAdd (9, "Luis Suarez"))
            {
                Console.WriteLine("Se anadio el registro");
            }
            else 
            {
                Console.WriteLine("registro duplicado");             
            }
            

            foreach(var item in listado)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            var item1 =  listado.ContainsKey(9);
            var valor =  listado.GetValueOrDefault(9);
            Console.WriteLine(valor);

            Stack<int> stackint1 = new Stack<int>();
            stackint1.Push(10);
            stackint1.Push(20);
            stackint1.Push(30);
            stackint1.Push(40);

            while(stackint1.Count > 0)
            {
                Console.WriteLine(  stackint1.Pop());
            }

            Queue <int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            while(queue.Count > 0)
                Console.WriteLine( queue.Dequeue());

        }
    }
}
