using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCoDetDiot
    {
        public int DoctoCoDetId { get; set; }
        public string IgnorarOperacion { get; set; }
        public int? TerceroCoId { get; set; }
        public string TipoOperacion { get; set; }
        public DateTime? Fecha { get; set; }
        public string EsDevolucion { get; set; }
        public decimal? ImporteBaseIvaGral { get; set; }
        public decimal? IvaNoAcredGral { get; set; }
        public decimal? ImporteBaseIva0 { get; set; }
        public decimal? ImporteBaseIvaFronterizo { get; set; }
        public decimal? IvaNoAcredFronterizo { get; set; }
        public decimal? ImporteBaseIvaExento { get; set; }
        public decimal? ImporteBaseIvaGralImp { get; set; }
        public decimal? IvaNoAcredGralImp { get; set; }
        public decimal? ImporteBaseIvaExentoImp { get; set; }
        public decimal? IvaRetenido { get; set; }
        public decimal? IvaDevolucion { get; set; }

        public virtual DoctosCoDet DoctoCoDet { get; set; }
        public virtual TercerosCo TerceroCo { get; set; }
    }
}
