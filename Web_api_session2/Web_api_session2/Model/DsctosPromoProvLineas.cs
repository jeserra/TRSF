using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosPromoProvLineas
    {
        public int DsctoPromoProvLineaId { get; set; }
        public int PolDsctoPromoProvId { get; set; }
        public int LineaArticuloId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual LineasArticulos LineaArticulo { get; set; }
        public virtual PoliticasDsctosPromoProv PolDsctoPromoProv { get; set; }
    }
}
