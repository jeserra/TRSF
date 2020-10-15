using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DeptosNo
    {
        public DeptosNo()
        {
            CuentasNo = new HashSet<CuentasNo>();
            Empleados = new HashSet<Empleados>();
            ExcepGenerales = new HashSet<ExcepGenerales>();
            PagosNomina = new HashSet<PagosNomina>();
        }

        public int DeptoNoId { get; set; }
        public string Nombre { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<CuentasNo> CuentasNo { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
        public virtual ICollection<ExcepGenerales> ExcepGenerales { get; set; }
        public virtual ICollection<PagosNomina> PagosNomina { get; set; }
    }
}
