using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosArtproArts
    {
        public int DsctoArtproArtId { get; set; }
        public int PoliticaPreciosProvId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual PoliticasPreciosProv PoliticaPreciosProv { get; set; }
    }
}
