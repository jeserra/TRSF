using System;
using System.Collections.Generic;
using sample30.ReglasSerpientes;

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
            
            var reglaMeta = new ReglaMeta(CasillaMeta);

            Reglas = new List<IRegla>
            {
                new ReglaEscaleras(),
                new ReglaSerpientes(),
                reglaMeta
            };
              
        }

        protected int CasillaMeta  {get;set;}
        public List<Jugador> Jugadores {get;set;}
        public List<IRegla> Reglas {get;set;}
        public bool Finalizado {get;set;}

        public virtual int TirarDados ()
        {
            Random r = new Random();
            int rInt = r.Next(1, 6); //for ints
            return rInt; 
        }

        public virtual int Avanzar(int lanzamiento, int casillaActual)
        {
            int nuevaCasilla =  casillaActual + lanzamiento;
            foreach(var regla in Reglas)
            {
                if(regla.EsCasillaEspecial(nuevaCasilla, out int nuevaCasillaMasRegla))
                {
                    nuevaCasilla = nuevaCasillaMasRegla;   
                    break;
                }
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