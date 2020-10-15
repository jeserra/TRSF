using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ComisVenGrupo
    {
        public int ComisVenGrupoId { get; set; }
        public int PoliticaComisVenId { get; set; }
        public int GrupoLineaId { get; set; }
        public decimal? Comision { get; set; }

        public virtual GruposLineas GrupoLinea { get; set; }
        public virtual PoliticasComisionesVendedores PoliticaComisVen { get; set; }
    }
}
