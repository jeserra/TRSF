using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImpuestosDoctosPv
    {
        public int DoctoPvId { get; set; }
        public int ImpuestoId { get; set; }
        public decimal? VentaNeta { get; set; }
        public decimal VentaBruta { get; set; }
        public decimal? OtrosImpuestos { get; set; }
        public decimal? PctjeImpuesto { get; set; }
        public decimal? ImporteImpuesto { get; set; }
        public double UnidadesImpuesto { get; set; }
        public decimal? ImporteUnitarioImpuesto { get; set; }

        public virtual DoctosPv DoctoPv { get; set; }
        public virtual Impuestos Impuesto { get; set; }
    }
}
