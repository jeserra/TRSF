using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCpInfoBan
    {
        public int DoctoCpId { get; set; }
        public string TipoMovFiscal { get; set; }
        public string MetodoPago { get; set; }
        public int BeneficiarioId { get; set; }
        public int? CuentaBanId { get; set; }
        public string CuentaBanDest { get; set; }
        public string BancoDest { get; set; }
        public string NomBancoDestExt { get; set; }
        public string Refer { get; set; }

        public virtual Beneficiarios Beneficiario { get; set; }
        public virtual CuentasBancarias CuentaBan { get; set; }
        public virtual DoctosCp DoctoCp { get; set; }
    }
}
