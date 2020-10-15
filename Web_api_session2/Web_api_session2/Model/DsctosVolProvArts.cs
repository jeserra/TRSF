using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosVolProvArts
    {
        public int DsctoVolProvArtId { get; set; }
        public int PolDsctoVolProvId { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? Descuento { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual PoliticasDsctosVolProv PolDsctoVolProv { get; set; }
    }
}
