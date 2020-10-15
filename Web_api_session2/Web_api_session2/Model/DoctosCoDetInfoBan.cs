using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCoDetInfoBan
    {
        public int DoctoCoDetInfoBanId { get; set; }
        public int DoctoCoDetId { get; set; }
        public string TipoMovFiscal { get; set; }
        public string MetodoPago { get; set; }
        public decimal? Importe { get; set; }
        public int? BeneficiarioId { get; set; }
        public int? TerceroCoId { get; set; }
        public int? CuentaBanId { get; set; }
        public string CuentaBanTercero { get; set; }
        public string BancoTercero { get; set; }
        public string NomBancoTerceroExt { get; set; }
        public string Refer { get; set; }

        public virtual Beneficiarios Beneficiario { get; set; }
        public virtual CuentasBancarias CuentaBan { get; set; }
        public virtual DoctosCoDet DoctoCoDet { get; set; }
        public virtual TercerosCo TerceroCo { get; set; }
    }
}
