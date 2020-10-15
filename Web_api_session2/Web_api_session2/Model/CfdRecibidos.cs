using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CfdRecibidos
    {
        public int CfdRecibidoId { get; set; }
        public string ClaveSistema { get; set; }
        public int DoctoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Xml { get; set; }
        public int? CfdiId { get; set; }

        public virtual RepositorioCfdi Cfdi { get; set; }
    }
}
