using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class UsosAnticiposCc
    {
        public int AnticipoCcId { get; set; }
        public int DoctoCcId { get; set; }
        public string TipoUso { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public decimal Impuesto { get; set; }
        public int? DoctoCcAcrId { get; set; }
        public string PorDepositar { get; set; }
        public DateTime? FechaHora { get; set; }

        public virtual AnticiposCc AnticipoCc { get; set; }
        public virtual DoctosCc DoctoCc { get; set; }
        public virtual DoctosCc DoctoCcAcr { get; set; }
    }
}
