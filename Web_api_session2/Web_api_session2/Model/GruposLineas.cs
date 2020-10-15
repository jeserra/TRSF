using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class GruposLineas
    {
        public GruposLineas()
        {
            ComisVenGrupo = new HashSet<ComisVenGrupo>();
            DsctosArtcliGrupos = new HashSet<DsctosArtcliGrupos>();
            DsctosArtproGrupos = new HashSet<DsctosArtproGrupos>();
            DsctosMaxGrupos = new HashSet<DsctosMaxGrupos>();
            DsctosPromoGrupos = new HashSet<DsctosPromoGrupos>();
            DsctosPromoProvGrupos = new HashSet<DsctosPromoProvGrupos>();
            DsctosVolGrupos = new HashSet<DsctosVolGrupos>();
            DsctosVolProvGrupos = new HashSet<DsctosVolProvGrupos>();
            GruposLineasWeb = new HashSet<GruposLineasWeb>();
            LineasArticulos = new HashSet<LineasArticulos>();
        }

        public int GrupoLineaId { get; set; }
        public string Nombre { get; set; }
        public string CuentaAlmacen { get; set; }
        public string CuentaCostoVenta { get; set; }
        public string CuentaVentas { get; set; }
        public string CuentaDevolVentas { get; set; }
        public string CuentaCompras { get; set; }
        public string CuentaDevolCompras { get; set; }
        public string AplicarFactorVenta { get; set; }
        public decimal FactorVenta { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<ComisVenGrupo> ComisVenGrupo { get; set; }
        public virtual ICollection<DsctosArtcliGrupos> DsctosArtcliGrupos { get; set; }
        public virtual ICollection<DsctosArtproGrupos> DsctosArtproGrupos { get; set; }
        public virtual ICollection<DsctosMaxGrupos> DsctosMaxGrupos { get; set; }
        public virtual ICollection<DsctosPromoGrupos> DsctosPromoGrupos { get; set; }
        public virtual ICollection<DsctosPromoProvGrupos> DsctosPromoProvGrupos { get; set; }
        public virtual ICollection<DsctosVolGrupos> DsctosVolGrupos { get; set; }
        public virtual ICollection<DsctosVolProvGrupos> DsctosVolProvGrupos { get; set; }
        public virtual ICollection<GruposLineasWeb> GruposLineasWeb { get; set; }
        public virtual ICollection<LineasArticulos> LineasArticulos { get; set; }
    }
}
