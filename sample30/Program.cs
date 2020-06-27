using System;
using static System.Console;
namespace sample30
{
    class Program
    {
        static void Main(string[] args)
        {
             Juego juego = new Juego();
             juego.Jugadores.Add(new Jugador(1));
             juego.Jugadores.Add(new Jugador(2));
             juego.Jugadores.Add(new Jugador(3));

             foreach(var item in juego.Jugadores)
             {
                item.LanzarDados+=juego.TirarDados;
                item.Avanzar+=juego.Avanzar;
             }

            int i=0;
             while(!juego.Finalizado)
             {
                 WriteLine($"===== Turno {i++} ======  ");
                 foreach(var item in juego.Jugadores)
                 {
                    item.Play();
                    if (juego.Finalizado)
                        break;
                 }
             }
                       
        }
    }
}
