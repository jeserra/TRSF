using System;

namespace  sample9
{
    
    public class SoccerPlayer: IPlayer
    {
         public string Name {get;set;}
         public  void Run ()
         {
             Console.Write("Corrio al centro del campo");
         }
         public  void Score()
         {
             Console.Write("anoto un gol");
         }
         public  void In ()
         {
             Console.Write("Entro al campo");
         }
    }
}