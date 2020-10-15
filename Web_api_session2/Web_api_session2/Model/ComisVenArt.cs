using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ComisVenArt
    {
        public int ComisVenArtId { get; set; }
        public int PoliticaComisVenId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Comision { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual PoliticasComisionesVendedores PoliticaComisVen { get; set; }
    }
}
