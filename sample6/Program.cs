using System;

namespace sample6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
           

            var shape = ShapeCreator.GetShape(3);
            Console.WriteLine(shape.GetArea());
            var shape2 = ShapeCreator.GetShape(4);
            Console.WriteLine(shape2.GetArea());
            Console.Read();
        }
    }
}
