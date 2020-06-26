using System;

namespace sample30
{
    class Program
    {
        static void Main(string[] args)
        {
             Juego juego = new Juego();
             juego.jugador1 = new Jugador();
             juego.jugador1.Avanzar+= juego.RevisarAvance;
             juego.jugador2 = new Jugador();
             juego.jugador2.Avanzar += juego.RevisarAvance;

             juego.jugador1.Play(6);
             juego.jugador2.Play(20);
                       
        }
    }
}
