using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresCuentasCo
    {
        public int CuentaId { get; set; }

        public virtual CuentasCo Cuenta { get; set; }
    }
}
