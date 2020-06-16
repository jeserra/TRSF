using System;

namespace sample9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Nuevo juego");
            IPlayer player = new SoccerPlayer();
            player.In();
            player.Name ="Chicharito";
            player.Run();
            player.Score();

            IPlayer player2 = new BasketBallPlayer();
            player2.In();
            player2.Name ="MIchael Jordan";
            player2.Run();
            player2.Score();
          //  Console.ReadKey();
        }
    }
}
