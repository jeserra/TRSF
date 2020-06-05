using System;

namespace sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.Nombre = "Miguel Angel";
            cliente.Apellido = "Ibarra";
            cliente.Fecha_Nacimiento = new DateTime(1998, 06, 15);

            Console.WriteLine($"Nombre : {cliente.Nombre} {cliente.Apellido}");
            Console.WriteLine($"Edad  : {cliente.Edad}");
        }
    }
}
