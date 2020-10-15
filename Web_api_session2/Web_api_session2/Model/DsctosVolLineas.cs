using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosVolLineas
    {
        public int DsctoVolLineaId { get; set; }
        public int PoliticaDsctoVolumenId { get; set; }
        public int LineaArticuloId { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? Descuento { get; set; }

        public virtual LineasArticulos LineaArticulo { get; set; }
        public virtual PoliticasDsctosVolumen PoliticaDsctoVolumen { get; set; }
    }
}
