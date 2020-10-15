using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosPromoProvArts
    {
        public int DsctoPromoProvArtId { get; set; }
        public int PolDsctoPromoProvId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual PoliticasDsctosPromoProv PolDsctoPromoProv { get; set; }
    }
}
