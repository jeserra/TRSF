using System;

namespace sample30
{
    public class Juego 
    {
        public Juego ()
        {
            CasillaMeta = 100;
        }

        private int CasillaMeta  {get;set;}
        public Jugador jugador1 {get;set;}
        public Jugador jugador2 {get;set;}
        public void RevisarAvance (int casillasAvance)
        {
            if(casillasAvance > CasillaMeta)
                Console.WriteLine("El jugador llego a la meta");
            else 
                Console.WriteLine($"El jugador Avanzo {casillasAvance}");
        }
    }
}