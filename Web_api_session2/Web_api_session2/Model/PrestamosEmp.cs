using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PrestamosEmp
    {
        public PrestamosEmp()
        {
            ExcepEmpleadosDet = new HashSet<ExcepEmpleadosDet>();
            PagosNominaDet = new HashSet<PagosNominaDet>();
            ViaticosNoDet = new HashSet<ViaticosNoDet>();
        }

        public int PrestamoEmpId { get; set; }
        public int EmpleadoId { get; set; }
        public int ConceptoNoId { get; set; }
        public decimal Cuota { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Importe { get; set; }
        public DateTime FechaIniRet { get; set; }
        public string Descripcion { get; set; }
        public string CuentaContable { get; set; }
        public string Estatus { get; set; }
        public DateTime? FechaFin { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual ICollection<ExcepEmpleadosDet> ExcepEmpleadosDet { get; set; }
        public virtual ICollection<PagosNominaDet> PagosNominaDet { get; set; }
        public virtual ICollection<ViaticosNoDet> ViaticosNoDet { get; set; }
    }
}
