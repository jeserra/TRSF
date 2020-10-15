using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SaldosBa
    {
        public int CuentaBanId { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public int Anomes { get; set; }
        public short UltimoDia { get; set; }
        public decimal? Depositos { get; set; }
        public decimal? Retiros { get; set; }
        public decimal? SaldoFinal { get; set; }

        public virtual CuentasBancarias CuentaBan { get; set; }
    }
}
