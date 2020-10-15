using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PoliticasComisionesCobradores
    {
        public PoliticasComisionesCobradores()
        {
            Cobradores = new HashSet<Cobradores>();
            ComisCobTipoCli = new HashSet<ComisCobTipoCli>();
            ComisCobZona = new HashSet<ComisCobZona>();
        }

        public int PoliticaComisCobId { get; set; }
        public string Nombre { get; set; }
        public string TipoCalculo { get; set; }
        public decimal? PctjeEnSaldoXven { get; set; }
        public decimal? PctjeEnSaldoVencido { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<Cobradores> Cobradores { get; set; }
        public virtual ICollection<ComisCobTipoCli> ComisCobTipoCli { get; set; }
        public virtual ICollection<ComisCobZona> ComisCobZona { get; set; }
    }
}
