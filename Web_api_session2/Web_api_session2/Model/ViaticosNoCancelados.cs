using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ViaticosNoCancelados
    {
        public int ViaticoNoCanceladoId { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoCancelacion { get; set; }
        public string Descripcion { get; set; }
        public int EmpleadoId { get; set; }
        public int? ViaticoNoId { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual ViaticosNo ViaticoNo { get; set; }
    }
}
