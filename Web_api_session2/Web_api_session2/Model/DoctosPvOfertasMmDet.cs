using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPvOfertasMmDet
    {
        public int DoctoPvOfertaMmDetId { get; set; }
        public int DoctoPvOfertaMmId { get; set; }
        public int DoctoPvDetId { get; set; }
        public int DoctoPvDetOrigId { get; set; }
        public string TipoDscto { get; set; }
        public decimal PctjeDscto { get; set; }
        public decimal PrecioEspecial { get; set; }
        public decimal Unidades { get; set; }
        public decimal PctjeDsctoOrig { get; set; }
        public decimal PrecioUnitarioOrig { get; set; }
        public decimal PrecioUnitarioImptoOrig { get; set; }

        public virtual DoctosPvOfertasMm DoctoPvOfertaMm { get; set; }
    }
}
