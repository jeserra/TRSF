using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PolizasCfdi
    {
        public int PolizaId { get; set; }
        public int CfdiId { get; set; }

        public virtual RepositorioCfdi Cfdi { get; set; }
        public virtual Polizas Poliza { get; set; }
    }
}
