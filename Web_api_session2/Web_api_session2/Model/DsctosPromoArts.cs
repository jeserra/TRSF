using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosPromoArts
    {
        public int DsctoPromoArtId { get; set; }
        public int PoliticaDsctoPromoId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual PoliticasDsctosPromocion PoliticaDsctoPromo { get; set; }
    }
}
