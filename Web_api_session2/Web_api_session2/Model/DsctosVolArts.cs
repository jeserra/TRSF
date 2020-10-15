using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosVolArts
    {
        public int DsctoVolArtId { get; set; }
        public int PoliticaDsctoVolumenId { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? Descuento { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual PoliticasDsctosVolumen PoliticaDsctoVolumen { get; set; }
    }
}
