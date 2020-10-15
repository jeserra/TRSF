using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Incidencias
    {
        public int IncidenciaId { get; set; }
        public int EmpleadoId { get; set; }
        public int RegPatronalId { get; set; }
        public int? NuevoRegPatronalId { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? SalarioDiario { get; set; }
        public decimal? SalarioHora { get; set; }
        public decimal? SalarioInteg { get; set; }
        public string CausaBaja { get; set; }
        public string TipoSalario { get; set; }
        public decimal? PctjeInteg { get; set; }
        public decimal? PercepVarDiaria { get; set; }
        public string SalintDefault { get; set; }
        public string FormaEmitida { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual RegPatronales NuevoRegPatronal { get; set; }
        public virtual RegPatronales RegPatronal { get; set; }
    }
}
