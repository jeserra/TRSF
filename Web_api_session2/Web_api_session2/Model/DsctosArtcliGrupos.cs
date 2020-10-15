using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosArtcliGrupos
    {
        public int DsctoArtcliGrupoId { get; set; }
        public int PoliticaDsctoArtCliId { get; set; }
        public int GrupoLineaId { get; set; }
        public decimal? Descuento { get; set; }

        public virtual GruposLineas GrupoLinea { get; set; }
        public virtual PoliticasDsctosArtCli PoliticaDsctoArtCli { get; set; }
    }
}
