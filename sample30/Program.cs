using System;

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

             while(!juego.Finalizado)
             {
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
