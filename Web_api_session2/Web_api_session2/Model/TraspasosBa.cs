using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TraspasosBa
    {
        public int DoctoBaRetId { get; set; }
        public int? DoctoBaDepId { get; set; }
        public int ConceptoBaId { get; set; }
        public int CuentaBanId { get; set; }
        public DateTime FechaAplic { get; set; }
        public string Refer { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? Importe { get; set; }

        public virtual ConceptosBa ConceptoBa { get; set; }
        public virtual CuentasBancarias CuentaBan { get; set; }
        public virtual DoctosBa DoctoBaDep { get; set; }
        public virtual DoctosBa DoctoBaRet { get; set; }
    }
}
