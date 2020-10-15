using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class GruposLineasWeb
    {
        public int GrupoLineaWebId { get; set; }
        public string ClaveSis { get; set; }
        public string Politica { get; set; }
        public int GrupoLineaId { get; set; }
        public string Accion { get; set; }

        public virtual GruposLineas GrupoLinea { get; set; }
    }
}
