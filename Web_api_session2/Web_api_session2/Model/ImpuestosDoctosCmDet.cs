using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImpuestosDoctosCmDet
    {
        public int DoctoCmId { get; set; }
        public int DoctoCmDetId { get; set; }
        public int ImpuestoId { get; set; }
        public string IdInternoTipoImpto { get; set; }
        public string TipoCalc { get; set; }
        public decimal? CompraNeta { get; set; }
        public decimal OtrosImpuestos { get; set; }
        public decimal? PctjeImpuesto { get; set; }
        public decimal ImporteImpuesto { get; set; }
        public double UnidadesImpuesto { get; set; }
        public decimal? ImporteUnitarioImpuesto { get; set; }

        public virtual Impuestos Impuesto { get; set; }
    }
}
