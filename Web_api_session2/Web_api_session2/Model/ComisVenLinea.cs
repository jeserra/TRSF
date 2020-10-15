using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ComisVenLinea
    {
        public int ComisVenLineaId { get; set; }
        public int PoliticaComisVenId { get; set; }
        public int LineaArticuloId { get; set; }
        public decimal? Comision { get; set; }

        public virtual LineasArticulos LineaArticulo { get; set; }
        public virtual PoliticasComisionesVendedores PoliticaComisVen { get; set; }
    }
}
