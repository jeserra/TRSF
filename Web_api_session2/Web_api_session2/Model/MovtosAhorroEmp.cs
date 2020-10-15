using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class MovtosAhorroEmp
    {
        public int MovtoAhorroEmpId { get; set; }
        public int EmpleadoId { get; set; }
        public int ConceptoNoId { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoMovto { get; set; }
        public string Descripcion { get; set; }
        public decimal? Importe { get; set; }
        public string FormaEmitida { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Empleados Empleado { get; set; }
    }
}
