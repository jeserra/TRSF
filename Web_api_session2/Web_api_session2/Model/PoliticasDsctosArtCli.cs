using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PoliticasDsctosArtCli
    {
        public PoliticasDsctosArtCli()
        {
            DsctosArtcliArts = new HashSet<DsctosArtcliArts>();
            DsctosArtcliGrupos = new HashSet<DsctosArtcliGrupos>();
            DsctosArtcliLineas = new HashSet<DsctosArtcliLineas>();
            PoliticasPreciosClientes = new HashSet<PoliticasPreciosClientes>();
            PreciosCliCli = new HashSet<PreciosCliCli>();
            PreciosCliTipo = new HashSet<PreciosCliTipo>();
            PreciosCliZona = new HashSet<PreciosCliZona>();
        }

        public int PoliticaDsctoArtCliId { get; set; }
        public string Nombre { get; set; }
        public decimal? Descuento { get; set; }
        public string EsDsctoExclusivo { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<DsctosArtcliArts> DsctosArtcliArts { get; set; }
        public virtual ICollection<DsctosArtcliGrupos> DsctosArtcliGrupos { get; set; }
        public virtual ICollection<DsctosArtcliLineas> DsctosArtcliLineas { get; set; }
        public virtual ICollection<PoliticasPreciosClientes> PoliticasPreciosClientes { get; set; }
        public virtual ICollection<PreciosCliCli> PreciosCliCli { get; set; }
        public virtual ICollection<PreciosCliTipo> PreciosCliTipo { get; set; }
        public virtual ICollection<PreciosCliZona> PreciosCliZona { get; set; }
    }
}
