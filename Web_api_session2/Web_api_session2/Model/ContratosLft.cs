using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ContratosLft
    {
        public int ContratoLftId { get; set; }
        public int TipoContLftId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual TiposContratosLft TipoContLft { get; set; }
    }
}
