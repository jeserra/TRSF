using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImpuestosDoctosPvDet
    {
        public int DoctoPvDetId { get; set; }
        public int ImpuestoId { get; set; }
        public int DoctoPvId { get; set; }
        public string IdInternoTipoImpto { get; set; }
        public string TipoCalc { get; set; }
        public decimal? ImporteImpuestoBruto { get; set; }
        public decimal? VentaNeta { get; set; }
        public decimal? VentaBruta { get; set; }
        public decimal OtrosImpuestos { get; set; }
        public decimal? PctjeImpuesto { get; set; }
        public decimal ImporteImpuesto { get; set; }
        public double UnidadesImpuesto { get; set; }
        public decimal? ImporteUnitarioImpuesto { get; set; }

        public virtual Impuestos Impuesto { get; set; }
    }
}
