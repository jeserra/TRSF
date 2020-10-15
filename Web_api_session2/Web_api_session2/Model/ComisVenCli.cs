using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ComisVenCli
    {
        public int ComisVenCliId { get; set; }
        public int PoliticaComisVenId { get; set; }
        public string ClaveCliente { get; set; }
        public int ClienteId { get; set; }
        public decimal? Comision { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual PoliticasComisionesVendedores PoliticaComisVen { get; set; }
    }
}
