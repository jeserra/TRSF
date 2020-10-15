using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ExcepEmpleados
    {
        public ExcepEmpleados()
        {
            ExcepEmpleadosDet = new HashSet<ExcepEmpleadosDet>();
        }

        public int ExcepEmpId { get; set; }
        public int NominaId { get; set; }
        public int EmpleadoId { get; set; }
        public string SeptimoDia { get; set; }
        public decimal DiasHrsPagar { get; set; }
        public decimal DiasHrsPagarA7 { get; set; }
        public decimal DiasVac { get; set; }
        public decimal DiasACot { get; set; }
        public string Faltas { get; set; }
        public string FaltasA7 { get; set; }
        public decimal? ImporteFaltas { get; set; }
        public int DiasAusImss { get; set; }
        public int DiasIncap { get; set; }
        public string IncapTotal { get; set; }
        public string HorasExt { get; set; }
        public int DiasExt { get; set; }
        public decimal? ImporteHorasExt { get; set; }
        public string HorasEsp { get; set; }
        public int DiasEsp { get; set; }
        public decimal? ImporteHorasEsp { get; set; }
        public string CausaBaja { get; set; }
        public decimal DiasBaseIndem { get; set; }
        public decimal DiasAntigIndem { get; set; }
        public decimal DiasPrimerIndem { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual Nominas Nomina { get; set; }
        public virtual ICollection<ExcepEmpleadosDet> ExcepEmpleadosDet { get; set; }
    }
}
