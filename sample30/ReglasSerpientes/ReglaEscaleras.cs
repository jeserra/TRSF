using System;
using System.Collections.Generic;
using static System.Console;

namespace sample30.ReglasSerpientes
{
    public class ReglaEscaleras : IRegla
    {

        private Dictionary <int, int> casillasEscaleras = new Dictionary<int, int>
        {
            {10, 29}, {28, 55}, {21,40},{78,89}, {79,100}
        };
        public bool EsCasillaEspecial(int casillaActual, out int nuevaCasilla)
        {
            var result = casillasEscaleras.TryGetValue(casillaActual, out int nuevaCasillaEscalera);
            if(result) 
            {   WriteLine($"Has caido en una serpiente, bajas desde la casilla  {casillaActual} hasta la casilla {nuevaCasillaEscalera}");
                nuevaCasilla = nuevaCasillaEscalera;
            }
            else
                nuevaCasilla = casillaActual;
            return result;
        }
    }
}