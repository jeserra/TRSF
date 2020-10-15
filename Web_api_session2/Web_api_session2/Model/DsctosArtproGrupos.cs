using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosArtproGrupos
    {
        public int DsctoArtproGrupoId { get; set; }
        public int PoliticaPreciosProvId { get; set; }
        public int GrupoLineaId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual GruposLineas GrupoLinea { get; set; }
        public virtual PoliticasPreciosProv PoliticaPreciosProv { get; set; }
    }
}
