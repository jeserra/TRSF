using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class EstatusAsimilados
    {
        public int EstatusAsimiladoId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Estatus { get; set; }

        public virtual Empleados Empleado { get; set; }
    }
}
