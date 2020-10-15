using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PoliticasPreciosClientes
    {
        public PoliticasPreciosClientes()
        {
            PreciosCliCli = new HashSet<PreciosCliCli>();
            PreciosCliTipo = new HashSet<PreciosCliTipo>();
            PreciosCliZona = new HashSet<PreciosCliZona>();
        }

        public int PoliticaPreciosCliId { get; set; }
        public string Nombre { get; set; }
        public int PrecioEmpresaId { get; set; }
        public int PoliticaDsctoArtCliId { get; set; }
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

        public virtual PoliticasDsctosArtCli PoliticaDsctoArtCli { get; set; }
        public virtual PreciosEmpresa PrecioEmpresa { get; set; }
        public virtual ICollection<PreciosCliCli> PreciosCliCli { get; set; }
        public virtual ICollection<PreciosCliTipo> PreciosCliTipo { get; set; }
        public virtual ICollection<PreciosCliZona> PreciosCliZona { get; set; }
    }
}
