using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PagosNominaCancelados
    {
        public int PagoNominaCanceladoId { get; set; }
        public int FrepagId { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoNom { get; set; }
        public int EmpleadoId { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual FrecuenciasPago Frepag { get; set; }
    }
}
