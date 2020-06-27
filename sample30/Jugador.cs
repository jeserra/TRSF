using System;
using static System.Console;
namespace sample30 
{
    public class Jugador 
    {
        public Jugador(int id)
        {
            this.Id = id;
        }
        public delegate int AvanzarHandler (int lanzamiento, int casillaActual); 
        public delegate int LanzarDadosHandler();
        public event AvanzarHandler Avanzar;
        public event LanzarDadosHandler LanzarDados;
        public int Id {get;set;}
        private int casillaActual {get;set;}
       
        public void Play( )
        {
            WriteLine($"Jugador {Id}");
            int lanzamientoDados =  OnLanzarDados();
            OnAvanzar(lanzamientoDados);
        }

        private int OnLanzarDados()
        {
            if(LanzarDados !=null)
                return LanzarDados();
            else
                return 0;
        }

        public void OnAvanzar(int lanzamiento)
        {
            if(Avanzar!= null)
            {
                int nuevaCasilla = Avanzar(lanzamiento, casillaActual);
                WriteLine($"se movio de la casilla {this.casillaActual} a la casilla {nuevaCasilla}"); 
                this.casillaActual = nuevaCasilla;
            }
        }
    }
}