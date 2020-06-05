using System;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my first program");

            int iCount = 100;
            string strMensaje = "Este es un mensaje nuevo";
            float precisionData = 120.132F;
            decimal PesosMexicanos = 120.40M;

            Console.WriteLine(iCount);
            Console.WriteLine(strMensaje);
            Console.WriteLine(precisionData);
            Console.WriteLine(PesosMexicanos);

            var NuevoMensaje ="Este es un nuevo mensaje";
            var floatValue = 120.123F;

            Console.WriteLine(NuevoMensaje);
            Console.WriteLine(floatValue);

            float suma = precisionData + floatValue;
            
            Console.WriteLine("El resultado es --  " + suma.ToString());
            Console.WriteLine("El resultado es ---  {0}", suma);

            Console.WriteLine($"El resultado es ---- {suma}");


        }
    }
}
