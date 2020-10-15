using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SaldosIn
    {
        public int ArticuloId { get; set; }
        public int AlmacenId { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public short UltimoDia { get; set; }
        public decimal? EntradasUnidades { get; set; }
        public decimal? SalidasUnidades { get; set; }
        public decimal? EntradasCosto { get; set; }
        public decimal? SalidasCosto { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual Articulos Articulo { get; set; }
    }
}
