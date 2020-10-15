using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosArtcliLineas
    {
        public int DsctoArtcliLineaId { get; set; }
        public int PoliticaDsctoArtCliId { get; set; }
        public int LineaArticuloId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual LineasArticulos LineaArticulo { get; set; }
        public virtual PoliticasDsctosArtCli PoliticaDsctoArtCli { get; set; }
    }
}
