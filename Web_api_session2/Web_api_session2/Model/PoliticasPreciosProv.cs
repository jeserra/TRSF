using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PoliticasPreciosProv
    {
        public PoliticasPreciosProv()
        {
            DsctosArtproArts = new HashSet<DsctosArtproArts>();
            DsctosArtproGrupos = new HashSet<DsctosArtproGrupos>();
            DsctosArtproLineas = new HashSet<DsctosArtproLineas>();
        }

        public int PoliticaPreciosProvId { get; set; }
        public string Nombre { get; set; }
        public int ProveedorId { get; set; }
        public int PrecioProvId { get; set; }
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

        public virtual PreciosProv PrecioProv { get; set; }
        public virtual Proveedores Proveedor { get; set; }
        public virtual ICollection<DsctosArtproArts> DsctosArtproArts { get; set; }
        public virtual ICollection<DsctosArtproGrupos> DsctosArtproGrupos { get; set; }
        public virtual ICollection<DsctosArtproLineas> DsctosArtproLineas { get; set; }
    }
}
