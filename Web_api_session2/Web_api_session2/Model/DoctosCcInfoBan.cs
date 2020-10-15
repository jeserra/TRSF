using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCcInfoBan
    {
        public int DoctoCcId { get; set; }
        public int BancoOrigId { get; set; }
        public string CuentaBanOrig { get; set; }
        public string CepTipoCadPago { get; set; }
        public string CepCertPago { get; set; }
        public string CepCadPago { get; set; }
        public string CepSelloPago { get; set; }

        public virtual Bancos BancoOrig { get; set; }
        public virtual DoctosCc DoctoCc { get; set; }
    }
}
