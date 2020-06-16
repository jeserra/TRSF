using System;

namespace library
{
    public class Volkswagen : IVehicle
    {
        public int Doors { get ; set; }

        public void Run()
        {
            Console.WriteLine("Arranca y corre");
        }
    }
}
