using System;

namespace sample30
{
    public class Dado : IDados
    {
        public int LanzarDados()
        {
            Random r = new Random();
            int rInt = r.Next(1, 6); //for ints
            return rInt; 
        }
    }
}