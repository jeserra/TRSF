using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ComisCobZona
    {
        public int ComisCobZonaId { get; set; }
        public int PoliticaComisCobId { get; set; }
        public int ZonaClienteId { get; set; }
        public decimal? PctjeEnSaldoXven { get; set; }
        public decimal? PctjeEnSaldoVencido { get; set; }

        public virtual PoliticasComisionesCobradores PoliticaComisCob { get; set; }
        public virtual ZonasClientes ZonaCliente { get; set; }
    }
}
