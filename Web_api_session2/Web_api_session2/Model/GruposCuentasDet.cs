using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class GruposCuentasDet
    {
        public int GrupoCuentasDetId { get; set; }
        public int GrupoCuentasId { get; set; }
        public string CuentaPtIni { get; set; }
        public string CuentaPtFin { get; set; }
        public string CuentaJtIni { get; set; }
        public string CuentaJtFin { get; set; }

        public virtual GruposCuentas GrupoCuentas { get; set; }
    }
}
