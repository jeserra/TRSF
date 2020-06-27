using sample30;
using System.Collections.Generic;
using static System.Console;

namespace sample30.ReglasSerpientes
{
    public class ReglaSerpientes : IRegla
    {
        private Dictionary<int, int> casillasSerpientes = new Dictionary<int, int>
        {
            {78,58}, {91,35}, {99,5}, {96,75}, {72,50}, {37,17}
        };
        public bool EsCasillaEspecial(int casillaActual, out int nuevaCasilla)
        {
            var result = casillasSerpientes.TryGetValue(casillaActual, out int nuevaCasillaSerpiente);
            if(result) 
            {   
                WriteLine($"Has caido en una serpiente, bajas desde la casilla  {casillaActual} hasta la casilla {nuevaCasillaSerpiente}");
                nuevaCasilla = nuevaCasillaSerpiente;
            }
            else
                nuevaCasilla = casillaActual;
            return result;
        }
    }
}