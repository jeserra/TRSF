using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ComisVenTipoCli
    {
        public int ComisVenTipoCliId { get; set; }
        public int PoliticaComisVenId { get; set; }
        public int TipoClienteId { get; set; }
        public decimal? Comision { get; set; }

        public virtual PoliticasComisionesVendedores PoliticaComisVen { get; set; }
        public virtual TiposClientes TipoCliente { get; set; }
    }
}
