using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosPromoGrupos
    {
        public int DsctoPromoGrupoId { get; set; }
        public int PoliticaDsctoPromoId { get; set; }
        public int GrupoLineaId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual GruposLineas GrupoLinea { get; set; }
        public virtual PoliticasDsctosPromocion PoliticaDsctoPromo { get; set; }
    }
}
