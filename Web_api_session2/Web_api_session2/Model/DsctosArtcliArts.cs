using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosArtcliArts
    {
        public int DsctoArtcliArtId { get; set; }
        public int PoliticaDsctoArtCliId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual PoliticasDsctosArtCli PoliticaDsctoArtCli { get; set; }
    }
}
