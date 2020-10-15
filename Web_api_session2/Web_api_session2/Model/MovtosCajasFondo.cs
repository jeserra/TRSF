using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class MovtosCajasFondo
    {
        public int MovtoCajaFondoId { get; set; }
        public int MovtoCajaId { get; set; }
        public int FormaCobroId { get; set; }
        public decimal? Importe { get; set; }

        public virtual FormasCobro FormaCobro { get; set; }
        public virtual MovtosCajas MovtoCaja { get; set; }
    }
}
