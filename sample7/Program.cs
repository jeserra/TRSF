using System;

namespace sample7
{
    class Program
    {
        static void Main(string[] args)
        {
           var newElector = new Elector2021();
           newElector.SetData("Juan", "Perez", "JDSAdsa");
           Console.WriteLine(newElector.Nombre);
        }
    }
}
