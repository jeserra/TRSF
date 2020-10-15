using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PoliticasDsctosVolumen
    {
        public PoliticasDsctosVolumen()
        {
            DsctosVolArts = new HashSet<DsctosVolArts>();
            DsctosVolGlobales = new HashSet<DsctosVolGlobales>();
            DsctosVolGrupos = new HashSet<DsctosVolGrupos>();
            DsctosVolLineas = new HashSet<DsctosVolLineas>();
        }

        public int PoliticaDsctoVolumenId { get; set; }
        public string Nombre { get; set; }
        public string EsDsctoExclusivo { get; set; }
        public string Habilitada { get; set; }
        public string EsPermanente { get; set; }
        public DateTime? FechaIniVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<DsctosVolArts> DsctosVolArts { get; set; }
        public virtual ICollection<DsctosVolGlobales> DsctosVolGlobales { get; set; }
        public virtual ICollection<DsctosVolGrupos> DsctosVolGrupos { get; set; }
        public virtual ICollection<DsctosVolLineas> DsctosVolLineas { get; set; }
    }
}
