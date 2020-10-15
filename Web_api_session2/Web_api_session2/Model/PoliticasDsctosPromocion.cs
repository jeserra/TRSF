using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PoliticasDsctosPromocion
    {
        public PoliticasDsctosPromocion()
        {
            DsctosPromoArts = new HashSet<DsctosPromoArts>();
            DsctosPromoGrupos = new HashSet<DsctosPromoGrupos>();
            DsctosPromoLineas = new HashSet<DsctosPromoLineas>();
        }

        public int PoliticaDsctoPromoId { get; set; }
        public string Nombre { get; set; }
        public decimal? Descuento { get; set; }
        public string EsDsctoExclusivo { get; set; }
        public string Habilitada { get; set; }
        public string EsPermanente { get; set; }
        public DateTime? FechaIniVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string AplicarHorario { get; set; }
        public TimeSpan? HoraIni { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<DsctosPromoArts> DsctosPromoArts { get; set; }
        public virtual ICollection<DsctosPromoGrupos> DsctosPromoGrupos { get; set; }
        public virtual ICollection<DsctosPromoLineas> DsctosPromoLineas { get; set; }
    }
}
