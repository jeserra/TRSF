using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Incapacidades
    {
        public int IncapacidadId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Ramo { get; set; }
        public string TipoRiesgo { get; set; }
        public string Secuela { get; set; }
        public string Folio { get; set; }
        public short Dias { get; set; }
        public string ControlIncap { get; set; }
        public decimal? Porcentaje { get; set; }
        public string Descripcion { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Empleados Empleado { get; set; }
    }
}
