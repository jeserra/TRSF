using System;

namespace sample30 
{
    public class Jugador 
    {
        public delegate void AvanzarHandler (int pasos); 
        public event AvanzarHandler Avanzar;

        private int CasillaInicial {get;set;}
        private int UltimoAvance {get;set;}
        public void Play(int nuevaCasilla)
        {
            if(nuevaCasilla > CasillaInicial)
            {
                
                UltimoAvance = nuevaCasilla -CasillaInicial;
                CasillaInicial = nuevaCasilla;
                OnAvanzar();
            }
        }

        public void OnAvanzar()
        {
            if(Avanzar!= null)
                Avanzar(UltimoAvance);
        }
    }
}