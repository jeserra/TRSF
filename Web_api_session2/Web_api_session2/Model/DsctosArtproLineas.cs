using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosArtproLineas
    {
        public int DsctoArtproLineaId { get; set; }
        public int PoliticaPreciosProvId { get; set; }
        public int LineaArticuloId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual LineasArticulos LineaArticulo { get; set; }
        public virtual PoliticasPreciosProv PoliticaPreciosProv { get; set; }
    }
}
