using System;
using System.Collections.Generic;

using static System.Console;
namespace sample30
{
  public class JuegoDelaOca:Juego
  {
      public JuegoDelaOca ()
      {
          Jugadores = new List<Jugador>();
            CasillaMeta = 63;
            Finalizado = false;
      }
      public override int TirarDados()
      {
          Random r = new Random();
            int rInt = r.Next(1,12); //for ints
            return rInt; 
      }
      public override int Avanzar(int lanzamiento,  int casillaActual)
      {
          
          if(casillaActual%9 == 0)
          {
              if(casillaActual ==0)
              {
                  casillaActual =27;
              }
              else 
                casillaActual += lanzamiento*2;
          }
          else
            casillaActual += lanzamiento;

          if(casillaActual == CasillaMeta)
          {
              Finalizado = true;
            WriteLine("Ha gandado!!");
          }
          else if (casillaActual == 54)
            WriteLine("Carcel");

            return 10;
      }

  }  
} 