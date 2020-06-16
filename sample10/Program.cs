using System;

namespace sample10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal fido = new Animal();
            fido.Legs = 4;
            Animal solovino = new Animal();
            solovino.Legs =3;

            Console.WriteLine( fido.CompareTo(solovino));

            Persona persona1 = new Persona()
            {
                 id = 10,
                 Name = "Juan"
            };

            Persona persona2 = new Persona()
            {
                id = 20,
                Name = "Pedro"
            };

            Console.WriteLine(persona1.CompareTo(persona2));
        }
    }
}
