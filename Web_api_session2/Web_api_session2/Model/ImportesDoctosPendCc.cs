using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImportesDoctosPendCc
    {
        public int ImpteDoctoPendCcId { get; set; }
        public int DoctoPendCcId { get; set; }
        public string TipoImpte { get; set; }
        public int? DoctoCcAcrId { get; set; }
        public int? ConceptoDoctoAcrId { get; set; }
        public string FolioDoctoAcr { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Impuesto { get; set; }
        public decimal? IvaRetenido { get; set; }
        public decimal? IsrRetenido { get; set; }
        public decimal? DsctoPpag { get; set; }
        public decimal? PctjeComisCob { get; set; }

        public virtual ConceptosCc ConceptoDoctoAcr { get; set; }
        public virtual DoctosCc DoctoCcAcr { get; set; }
        public virtual DoctosPendCc DoctoPendCc { get; set; }
    }
}
