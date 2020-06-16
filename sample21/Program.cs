using System;
using System.IO;
using System.Collections.Generic;
namespace sample21
{
    class Program
    {
        static void Main(string[] args)
        {
             var lineas  =File.ReadAllLines(@"C:\Users\Lenovo User\Documents\TRSF\prueba.txt");
             foreach(var item in lineas)
             {
                 Console.WriteLine("Linea  --- -") ;
                Console.WriteLine(item);
             }
            Console.WriteLine("Hello World!");

            List<String> Listado = new List<string>();
            Listado.Add("Lunes 20 de junio");
            Listado.Add("Martes 21 de Junio");
            Listado.Add("Miercoles 22 de junio");

            File.WriteAllLines(@"C:\Users\Lenovo User\Documents\TRSF\calendario.txt", Listado);
            
        }
    }
}
