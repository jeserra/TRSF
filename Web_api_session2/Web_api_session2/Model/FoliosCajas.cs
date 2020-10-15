using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FoliosCajas
    {
        public int CajaId { get; set; }
        public string TipoDocto { get; set; }
        public string Serie { get; set; }
        public int? Consecutivo { get; set; }

        public virtual Cajas Caja { get; set; }
    }
}
