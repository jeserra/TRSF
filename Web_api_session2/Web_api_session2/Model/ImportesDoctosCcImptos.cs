using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImportesDoctosCcImptos
    {
        public int ImpteDoctoCcImptoId { get; set; }
        public int ImpteDoctoCcId { get; set; }
        public int ImpuestoId { get; set; }
        public decimal? Importe { get; set; }
        public decimal? PctjeImpuesto { get; set; }
        public decimal? Impuesto { get; set; }

        public virtual ImportesDoctosCc ImpteDoctoCc { get; set; }
        public virtual Impuestos ImpuestoNavigation { get; set; }
    }
}
