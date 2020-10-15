using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImpuestosGravados
    {
        public int TipoImptoId { get; set; }
        public int TipoImptoGravadoId { get; set; }

        public virtual TiposImpuestos TipoImpto { get; set; }
        public virtual TiposImpuestos TipoImptoGravado { get; set; }
    }
}
