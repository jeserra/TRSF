
using System;
namespace sample5
{
    public class Cliente
    {
        string _apellido ;

        public string Nombre {get;set;}
        public string Apellido 
        {
            get
            { 
                return  "Von " + _apellido;
            } 
            set 
            { 
                _apellido = value;
            }
        }

        public DateTime Fecha_Nacimiento {get;set;}
        public int Edad {
            get 
            {
                return Math.Abs( (int) Fecha_Nacimiento.Subtract(DateTime.Today).TotalDays / 365);
            }
        }  

    }
}