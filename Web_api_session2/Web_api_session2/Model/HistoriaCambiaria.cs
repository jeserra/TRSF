using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class HistoriaCambiaria
    {
        public int HistoriaCambId { get; set; }
        public int MonedaId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? TipoCambioCobros { get; set; }
        public decimal? TipoCambio { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Monedas Moneda { get; set; }
    }
}
