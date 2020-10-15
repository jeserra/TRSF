using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SaldosCc
    {
        public int ClienteId { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public short UltimoDia { get; set; }
        public decimal? CargosCxc { get; set; }
        public decimal? CargosXacr { get; set; }
        public decimal? CreditosCxc { get; set; }
        public decimal? CreditosXacr { get; set; }
        public decimal? CreditosCxcXlib { get; set; }
        public decimal? CreditosXacrXlib { get; set; }

        public virtual Clientes Cliente { get; set; }
    }
}
