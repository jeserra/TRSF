using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TiposPolizasDet
    {
        public int TipoPolizaDetId { get; set; }
        public int TipoPolizaId { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public int Consecutivo { get; set; }

        public virtual TiposPolizas TipoPoliza { get; set; }
    }
}
