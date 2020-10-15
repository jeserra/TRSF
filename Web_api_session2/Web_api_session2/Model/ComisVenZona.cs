using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ComisVenZona
    {
        public int ComisVenZonaId { get; set; }
        public int PoliticaComisVenId { get; set; }
        public int ZonaClienteId { get; set; }
        public decimal? Comision { get; set; }

        public virtual PoliticasComisionesVendedores PoliticaComisVen { get; set; }
        public virtual ZonasClientes ZonaCliente { get; set; }
    }
}
