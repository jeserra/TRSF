using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SaldosCo
    {
        public int CuentaId { get; set; }
        public int DeptoCoId { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public int Anomes { get; set; }
        public short UltimoDia { get; set; }
        public decimal? Cargos { get; set; }
        public decimal? Abonos { get; set; }
        public decimal? SaldoFinal { get; set; }

        public virtual CuentasCo Cuenta { get; set; }
        public virtual DeptosCo DeptoCo { get; set; }
    }
}
