using System;

namespace sample18
{
    class Program
    {
        static void Main(string[] args)
        {

            Payment payment = new Payment();
            payment.ProcessPayment();

            Console.Read();

            //int zero = 10;
           try 
           {
               //int division = 10/zero ;
               // System.IO.File.ReadAllBytes(@"C:\archivo.txt");
                throw new BussinesException()
                 {
                     IDError = 20
                 };
           }
           catch(DivideByZeroException ex)
           {
               Console.WriteLine(ex.Message);
           }
           catch(BussinesException gex)
           when (gex.IDError == 10)
           
           {
                Console.WriteLine(gex.Message);
           } 
             catch(BussinesException gex1)
           
           {
                Console.WriteLine("Error sin id");
           } 
           finally
           {
               Console.WriteLine("Se ejecuta siempre");
           }



            //System.GC.Collect();
        }

        


    }
}
