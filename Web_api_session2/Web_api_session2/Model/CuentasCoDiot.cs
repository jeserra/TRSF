using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CuentasCoDiot
    {
        public int CuentaId { get; set; }
        public string MonitorearDebe { get; set; }
        public string MonitorearHaber { get; set; }

        public virtual CuentasCo Cuenta { get; set; }
    }
}
