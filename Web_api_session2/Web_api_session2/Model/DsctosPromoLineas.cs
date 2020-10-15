using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosPromoLineas
    {
        public int DsctoPromoLineaId { get; set; }
        public int PoliticaDsctoPromoId { get; set; }
        public int LineaArticuloId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual LineasArticulos LineaArticulo { get; set; }
        public virtual PoliticasDsctosPromocion PoliticaDsctoPromo { get; set; }
    }
}
