using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PoliticasDsctosPromoProv
    {
        public PoliticasDsctosPromoProv()
        {
            DsctosPromoProvArts = new HashSet<DsctosPromoProvArts>();
            DsctosPromoProvGrupos = new HashSet<DsctosPromoProvGrupos>();
            DsctosPromoProvLineas = new HashSet<DsctosPromoProvLineas>();
        }

        public int PolDsctoPromoProvId { get; set; }
        public string Nombre { get; set; }
        public int ProveedorId { get; set; }
        public decimal? Descuento { get; set; }
        public string EsDsctoExclusivo { get; set; }
        public string Habilitada { get; set; }
        public string EsPermanente { get; set; }
        public DateTime? FechaIniVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }

        public virtual Proveedores Proveedor { get; set; }
        public virtual ICollection<DsctosPromoProvArts> DsctosPromoProvArts { get; set; }
        public virtual ICollection<DsctosPromoProvGrupos> DsctosPromoProvGrupos { get; set; }
        public virtual ICollection<DsctosPromoProvLineas> DsctosPromoProvLineas { get; set; }
    }
}
