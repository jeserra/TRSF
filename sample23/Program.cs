using System;
using System.Text;

namespace sample23
{
    class Program
    {
        static void Main(string[] args)
        {
            SillevaReturn();
            
            StringBuilder sb = new StringBuilder();
            sb.Append("Soy la flor silvestre que marchito el olvido");
            sb.Append(" y vivo en este eterno pesar");


            Console.WriteLine(sb.ToString());

            sb.Replace("flor", "rosa");

            Console.WriteLine(sb.Length);
            Console.WriteLine (sb.ToString());

            sb.Remove(sb.Length - 10, 10);
            Console.WriteLine (sb.ToString());
        }

        public static void SillevaReturn ()
        {
            Console.WriteLine("Un metodo void puede llevar return");
            return;
        }
    }
}
