using System;

namespace sample8
{
    class Program
    {
        static void Main(string[] args)
        {

             
         // TablaMultiplicar(5);
        //  TablaMultiplicar(3);
          
          // int a ;
       //   int b = 20;

         // Console.WriteLine($" Suma de {a} + {b} = {Suma(a,b)}" );

          //  sumatoria(ref a);
           // Console.WriteLine(a);

             /*sumatoria2(out int a );
             Console.WriteLine(a);

             if (Int32.TryParse("100", out int result ))
                Console.WriteLine(result);

            Console.WriteLine(sumatoria3(2));
            Console.WriteLine(sumatoria3(2, 12)); */

            int [] parametros = new int[2];
            parametros[0] = 100;
            parametros[1] = 200;
            multiparameters(parametros);
            //multiparameters

        }

        static void TablaMultiplicar (byte multiplicador)
        {
            for(int  i=1; i<= 9; i++)
                Console.WriteLine($" {multiplicador} *  {i} = {i*multiplicador} ");
        }

        static int Suma(int a , int b)
        {
            return a + b;
        }

        static void sumatoria (ref int a)
        {
            a = a*12;
        }

        static void sumatoria2 (out int a)
        {
            a = 10 * 20;
        }

        static int sumatoria3  (int a, int b = 10)
        {
            return a * b;
        }

        static void multiparameters ( int[] numeros)
        {
            if(numeros.Length == 0)
                Console.WriteLine ("no parametros");
                else if( numeros.Length == 1)
                    Console.WriteLine($"Bienvenido {numeros[0]}");
                    else 
                        Console.WriteLine($"muchos parametros ");
        }
    }

    
}
