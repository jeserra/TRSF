using System;

namespace library
{
    public  partial class Embrajer : IVehicle
    {
        partial void Fly()
        {
            Console.Write("Volando");
        }
    }
}