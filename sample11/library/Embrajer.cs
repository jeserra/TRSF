using System;

namespace library
{
    public  partial class Embrajer : IVehicle
    {
        public int Doors { get ; set; }

        public void Run()
        {
            Console.WriteLine("El avion arranca por la pista");
            Fly();
        }

         partial void Fly();

    }
}