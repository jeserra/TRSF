using System;
namespace sample9
{
    public class BasketBallPlayer :IPlayer{

        public string Name {get;set;}
         public  void Run ()
         {
             Console.Write("Corrio al centro del campo");
         }
         public  void Score()
         {
             Console.Write("anoto una canasta");
         }
         public  void In ()
         {
             Console.Write("Entro a la duela");
         }
    }
}