using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LineasArticulos
    {
        public LineasArticulos()
        {
            Articulos = new HashSet<Articulos>();
            ComisVenLinea = new HashSet<ComisVenLinea>();
            DsctosArtcliLineas = new HashSet<DsctosArtcliLineas>();
            DsctosArtproLineas = new HashSet<DsctosArtproLineas>();
            DsctosMaxLineas = new HashSet<DsctosMaxLineas>();
            DsctosPromoLineas = new HashSet<DsctosPromoLineas>();
            DsctosPromoProvLineas = new HashSet<DsctosPromoProvLineas>();
            DsctosVolLineas = new HashSet<DsctosVolLineas>();
            DsctosVolProvLineas = new HashSet<DsctosVolProvLineas>();
            LineasArticulosWeb = new HashSet<LineasArticulosWeb>();
        }

        public int LineaArticuloId { get; set; }
        public string Nombre { get; set; }
        public int? GrupoLineaId { get; set; }
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

        public virtual GruposLineas GrupoLinea { get; set; }
        public virtual ICollection<Articulos> Articulos { get; set; }
        public virtual ICollection<ComisVenLinea> ComisVenLinea { get; set; }
        public virtual ICollection<DsctosArtcliLineas> DsctosArtcliLineas { get; set; }
        public virtual ICollection<DsctosArtproLineas> DsctosArtproLineas { get; set; }
        public virtual ICollection<DsctosMaxLineas> DsctosMaxLineas { get; set; }
        public virtual ICollection<DsctosPromoLineas> DsctosPromoLineas { get; set; }
        public virtual ICollection<DsctosPromoProvLineas> DsctosPromoProvLineas { get; set; }
        public virtual ICollection<DsctosVolLineas> DsctosVolLineas { get; set; }
        public virtual ICollection<DsctosVolProvLineas> DsctosVolProvLineas { get; set; }
        public virtual ICollection<LineasArticulosWeb> LineasArticulosWeb { get; set; }
    }
}
