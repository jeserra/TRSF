using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PoliticasDsctosVolProv
    {
        public PoliticasDsctosVolProv()
        {
            DsctosVolProvArts = new HashSet<DsctosVolProvArts>();
            DsctosVolProvGlob = new HashSet<DsctosVolProvGlob>();
            DsctosVolProvGrupos = new HashSet<DsctosVolProvGrupos>();
            DsctosVolProvLineas = new HashSet<DsctosVolProvLineas>();
        }

        public int PolDsctoVolProvId { get; set; }
        public string Nombre { get; set; }
        public int ProveedorId { get; set; }
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
        public virtual ICollection<DsctosVolProvArts> DsctosVolProvArts { get; set; }
        public virtual ICollection<DsctosVolProvGlob> DsctosVolProvGlob { get; set; }
        public virtual ICollection<DsctosVolProvGrupos> DsctosVolProvGrupos { get; set; }
        public virtual ICollection<DsctosVolProvLineas> DsctosVolProvLineas { get; set; }
    }
}
