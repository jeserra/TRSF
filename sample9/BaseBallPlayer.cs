using System;
namespace sample9
{
    public class BaseBallPlayer :IPlayer{

        public string Name {get;set;}
         public  void Run ()
         {
             Console.Write("Corrio al centro del diamante");
         }
         public  void Score()
         {
             Console.Write("anoto un batazo de hit");
         }
         public  void In ()
         {
             Console.Write("Entro al diamante");
         }
    }
}