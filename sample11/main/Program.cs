using System;
using library;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new Volkswagen();

            vehicle.Doors = 2;
            Console.WriteLine($"{vehicle.Doors}");

            IVehicle Avion = new Embrajer();
            Avion.Run();
            
        }
    }
}
