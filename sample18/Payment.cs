using System;

namespace sample18
{
    public class Payment 
    {
        static int Count = 0;
         public decimal Amount {get;set;}
         public string Concept {get;set;}

         public bool ProcessPayment ()
         {

             Count ++;
             try 
             {

             
             if(Count < 3)
                throw new BussinesException();
             }
             catch(BussinesException )
             {
                 if(Count < 3 )
                    ProcessPayment();
                
                 Console.WriteLine("No se pudo procesar el pago");
                 return false;
             }

             return true;


         }
    }
}