﻿using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosPromoProvGrupos
    {
        public int DsctoPromoProvGrupoId { get; set; }
        public int PolDsctoPromoProvId { get; set; }
        public int GrupoLineaId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual GruposLineas GrupoLinea { get; set; }
        public virtual PoliticasDsctosPromoProv PolDsctoPromoProv { get; set; }
    }
}
