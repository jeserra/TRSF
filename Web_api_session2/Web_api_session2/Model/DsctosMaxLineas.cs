using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosMaxLineas
    {
        public int DsctoMaxLineaId { get; set; }
        public int PoliticaDsctoMaximoId { get; set; }
        public int LineaArticuloId { get; set; }
        public decimal? DescuentoMaximo { get; set; }

        public virtual LineasArticulos LineaArticulo { get; set; }
        public virtual PoliticasDsctosMaximos PoliticaDsctoMaximo { get; set; }
    }
}
