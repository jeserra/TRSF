using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImportesDoctosCp
    {
        public ImportesDoctosCp()
        {
            ImportesDoctosCpImptos = new HashSet<ImportesDoctosCpImptos>();
        }

        public int ImpteDoctoCpId { get; set; }
        public int DoctoCpId { get; set; }
        public string Cancelado { get; set; }
        public string Aplicado { get; set; }
        public string TipoImpte { get; set; }
        public int? DoctoCpAcrId { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Impuesto { get; set; }
        public decimal? IvaRetenido { get; set; }
        public decimal? IsrRetenido { get; set; }
        public decimal? DsctoPpag { get; set; }

        public virtual DoctosCp DoctoCp { get; set; }
        public virtual DoctosCp DoctoCpAcr { get; set; }
        public virtual ICollection<ImportesDoctosCpImptos> ImportesDoctosCpImptos { get; set; }
    }
}
