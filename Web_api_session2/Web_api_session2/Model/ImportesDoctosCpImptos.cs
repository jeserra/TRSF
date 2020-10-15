using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImportesDoctosCpImptos
    {
        public int ImpteDoctoCpImptoId { get; set; }
        public int ImpteDoctoCpId { get; set; }
        public int ImpuestoId { get; set; }
        public decimal? Importe { get; set; }
        public decimal? PctjeImpuesto { get; set; }
        public decimal? Impuesto { get; set; }

        public virtual ImportesDoctosCp ImpteDoctoCp { get; set; }
        public virtual Impuestos ImpuestoNavigation { get; set; }
    }
}
