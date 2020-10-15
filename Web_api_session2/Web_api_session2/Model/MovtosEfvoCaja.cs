using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class MovtosEfvoCaja
    {
        public int DoctoPvCobroId { get; set; }
        public int CajaId { get; set; }
        public int FormaCobroId { get; set; }
        public decimal? Importe { get; set; }

        public virtual Cajas Caja { get; set; }
        public virtual DoctosPvCobros DoctoPvCobro { get; set; }
        public virtual FormasCobro FormaCobro { get; set; }
    }
}
