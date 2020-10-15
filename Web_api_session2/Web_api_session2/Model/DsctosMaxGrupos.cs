using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosMaxGrupos
    {
        public int DsctoMaxGrupoId { get; set; }
        public int PoliticaDsctoMaximoId { get; set; }
        public int GrupoLineaId { get; set; }
        public decimal? DescuentoMaximo { get; set; }

        public virtual GruposLineas GrupoLinea { get; set; }
        public virtual PoliticasDsctosMaximos PoliticaDsctoMaximo { get; set; }
    }
}
