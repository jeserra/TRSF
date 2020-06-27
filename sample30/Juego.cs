using System;
using System.Collections.Generic;
using static System.Console;
namespace sample30
{
    public class Juego 
    {
        public Juego ()
        {
            Jugadores = new List<Jugador>();
            CasillaMeta = 100;
            Finalizado = false;
        }

        protected int CasillaMeta  {get;set;}
        public List<Jugador> Jugadores {get;set;}
        public bool Finalizado {get;set;}
        private Dictionary<int, int> casillasSerpientes = new Dictionary<int, int>
        {
            {41,1}, {44,8}, {49,14}
        };

        private Dictionary <int, int> casillasEscaleras = new Dictionary<int, int>
        {
            {12, 30}, {51, 60}, {57,76},{76,85}, {78,100}
        };
        

        public virtual int TirarDados ()
        {
            Random r = new Random();
            int rInt = r.Next(1, 6); //for ints
            return rInt; 
        }

        public virtual int Avanzar(int lanzamiento, int casillaActual)
        {
            int nuevaCasilla =  casillaActual + lanzamiento;
            if(casillasSerpientes.TryGetValue(casillaActual, out int nuevaCasillaSerpiente))
            {
                
                WriteLine($"Has caido en una serpiente, bajas desde la casilla  {casillaActual} hasta la casilla {nuevaCasillaSerpiente}");
                nuevaCasilla = nuevaCasillaSerpiente;
            }
            else if(casillasEscaleras.TryGetValue(casillaActual, out int nuevaCasillaEscalera))
            {
                WriteLine($"Has caido en una escalera, subes desde la casilla  {casillaActual} hasta la casilla {nuevaCasillaEscalera}");
                nuevaCasilla = nuevaCasillaEscalera;
            }
            else if(nuevaCasilla > CasillaMeta )
            {
                nuevaCasilla = CasillaMeta - (casillaActual - CasillaMeta);
            } 

            if(nuevaCasilla == CasillaMeta)
            {
                WriteLine ("Ha ganado!!");
                Finalizado = true;
            }
            return nuevaCasilla;
           
        }
    }
}