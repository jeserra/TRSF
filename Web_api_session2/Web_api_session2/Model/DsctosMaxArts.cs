using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosMaxArts
    {
        public int DsctoMaxArtId { get; set; }
        public int PoliticaDsctoMaximoId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal? DescuentoMaximo { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual PoliticasDsctosMaximos PoliticaDsctoMaximo { get; set; }
    }
}
