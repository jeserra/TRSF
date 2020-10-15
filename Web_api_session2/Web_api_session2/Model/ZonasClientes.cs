using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ZonasClientes
    {
        public ZonasClientes()
        {
            Clientes = new HashSet<Clientes>();
            ComisCobZona = new HashSet<ComisCobZona>();
            ComisVenZona = new HashSet<ComisVenZona>();
            PreciosCliZona = new HashSet<PreciosCliZona>();
        }

        public int ZonaClienteId { get; set; }
        public string Nombre { get; set; }
        public string CuentaCxc { get; set; }
        public string CuentaAnticipos { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<ComisCobZona> ComisCobZona { get; set; }
        public virtual ICollection<ComisVenZona> ComisVenZona { get; set; }
        public virtual ICollection<PreciosCliZona> PreciosCliZona { get; set; }
    }
}
