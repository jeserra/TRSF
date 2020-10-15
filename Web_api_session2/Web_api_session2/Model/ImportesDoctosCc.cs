using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImportesDoctosCc
    {
        public ImportesDoctosCc()
        {
            ImportesDoctosCcImptos = new HashSet<ImportesDoctosCcImptos>();
        }

        public int ImpteDoctoCcId { get; set; }
        public int DoctoCcId { get; set; }
        public DateTime Fecha { get; set; }
        public string Cancelado { get; set; }
        public string Aplicado { get; set; }
        public string Estatus { get; set; }
        public string TipoImpte { get; set; }
        public int? DoctoCcAcrId { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Impuesto { get; set; }
        public decimal? IvaRetenido { get; set; }
        public decimal? IsrRetenido { get; set; }
        public decimal? DsctoPpag { get; set; }
        public decimal? PctjeComisCob { get; set; }

        public virtual DoctosCc DoctoCc { get; set; }
        public virtual DoctosCc DoctoCcAcr { get; set; }
        public virtual ICollection<ImportesDoctosCcImptos> ImportesDoctosCcImptos { get; set; }
    }
}
