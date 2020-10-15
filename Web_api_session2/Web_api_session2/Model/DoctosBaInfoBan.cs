using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosBaInfoBan
    {
        public int DoctoBaInfoBanId { get; set; }
        public int DoctoBaId { get; set; }
        public int? TerceroCoId { get; set; }
        public string MetodoPago { get; set; }
        public decimal Importe { get; set; }
        public string CuentaBanTercero { get; set; }
        public string BancoTercero { get; set; }
        public string NomBancoTerceroExt { get; set; }
        public string Refer { get; set; }

        public virtual DoctosBa DoctoBa { get; set; }
        public virtual TercerosCo TerceroCo { get; set; }
    }
}
