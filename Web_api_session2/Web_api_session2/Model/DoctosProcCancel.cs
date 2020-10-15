using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosProcCancel
    {
        public string ClaveSis { get; set; }
        public int DoctoId { get; set; }
        public string Estatus { get; set; }
        public int CfdiId { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }

        public virtual RepositorioCfdi Cfdi { get; set; }
    }
}
