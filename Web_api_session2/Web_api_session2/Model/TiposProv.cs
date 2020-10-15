using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TiposProv
    {
        public TiposProv()
        {
            Proveedores = new HashSet<Proveedores>();
        }

        public int TipoProvId { get; set; }
        public string Nombre { get; set; }
        public string CuentaCxp { get; set; }
        public string CuentaAnticipos { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<Proveedores> Proveedores { get; set; }
    }
}
