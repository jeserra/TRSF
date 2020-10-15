using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SaldosCp
    {
        public int ProveedorId { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public short UltimoDia { get; set; }
        public decimal? CargosCxp { get; set; }
        public decimal? CargosAnticipos { get; set; }
        public decimal? CreditosCxp { get; set; }
        public decimal? CreditosAnticipos { get; set; }

        public virtual Proveedores Proveedor { get; set; }
    }
}
