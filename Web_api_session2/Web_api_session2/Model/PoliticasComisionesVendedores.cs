using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PoliticasComisionesVendedores
    {
        public PoliticasComisionesVendedores()
        {
            ComisVenArt = new HashSet<ComisVenArt>();
            ComisVenCli = new HashSet<ComisVenCli>();
            ComisVenGrupo = new HashSet<ComisVenGrupo>();
            ComisVenLinea = new HashSet<ComisVenLinea>();
            ComisVenTipoCli = new HashSet<ComisVenTipoCli>();
            ComisVenZona = new HashSet<ComisVenZona>();
            Vendedores = new HashSet<Vendedores>();
        }

        public int PoliticaComisVenId { get; set; }
        public string Nombre { get; set; }
        public string TipoCalculo { get; set; }
        public decimal? Comision { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<ComisVenArt> ComisVenArt { get; set; }
        public virtual ICollection<ComisVenCli> ComisVenCli { get; set; }
        public virtual ICollection<ComisVenGrupo> ComisVenGrupo { get; set; }
        public virtual ICollection<ComisVenLinea> ComisVenLinea { get; set; }
        public virtual ICollection<ComisVenTipoCli> ComisVenTipoCli { get; set; }
        public virtual ICollection<ComisVenZona> ComisVenZona { get; set; }
        public virtual ICollection<Vendedores> Vendedores { get; set; }
    }
}
