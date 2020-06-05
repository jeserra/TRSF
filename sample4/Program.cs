using System;

namespace sample4
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            var mycounter  = new Counter();
           {
               
              contador =  mycounter.GetNextValue();

           };

            Console.WriteLine("Valor contador "); 
            Console.WriteLine(contador);

        //   for(int x = 1; x<=50; x++)
         //   Console.WriteLine( mycounter.GetNextValue());
           
        //   Console.WriteLine(mycounter.CurrentValue);


        }
    }

    public class Counter 
    { 
        private int _count = -1; 
        public int GetNextValue() 
        { 
            _count += 2; 
            return _count; 
        } 

        public int CurrentValue 
        {
            get {return _count;}
        }
    } 
}
