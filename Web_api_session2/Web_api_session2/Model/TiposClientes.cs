using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TiposClientes
    {
        public TiposClientes()
        {
            Clientes = new HashSet<Clientes>();
            ComisCobTipoCli = new HashSet<ComisCobTipoCli>();
            ComisVenTipoCli = new HashSet<ComisVenTipoCli>();
            PreciosCliTipo = new HashSet<PreciosCliTipo>();
        }

        public int TipoClienteId { get; set; }
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
        public virtual ICollection<ComisCobTipoCli> ComisCobTipoCli { get; set; }
        public virtual ICollection<ComisVenTipoCli> ComisVenTipoCli { get; set; }
        public virtual ICollection<PreciosCliTipo> PreciosCliTipo { get; set; }
    }
}
