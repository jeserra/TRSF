using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class GruposPagosElect
    {
        public GruposPagosElect()
        {
            Empleados = new HashSet<Empleados>();
        }

        public int GrupoPagoElectId { get; set; }
        public string Nombre { get; set; }
        public int CuentaBanId { get; set; }
        public string TipoCtabanPredet { get; set; }
        public string ClaveLayout { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual CuentasBancarias CuentaBan { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
