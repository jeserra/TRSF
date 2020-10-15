using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PoliticasDsctosMaximos
    {
        public PoliticasDsctosMaximos()
        {
            DsctosMaxArts = new HashSet<DsctosMaxArts>();
            DsctosMaxGrupos = new HashSet<DsctosMaxGrupos>();
            DsctosMaxLineas = new HashSet<DsctosMaxLineas>();
        }

        public int PoliticaDsctoMaximoId { get; set; }
        public string Nombre { get; set; }
        public decimal? DescuentoMaximo { get; set; }
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

        public virtual ICollection<DsctosMaxArts> DsctosMaxArts { get; set; }
        public virtual ICollection<DsctosMaxGrupos> DsctosMaxGrupos { get; set; }
        public virtual ICollection<DsctosMaxLineas> DsctosMaxLineas { get; set; }
    }
}
