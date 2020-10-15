using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class RedondeoPrecios
    {
        public int RedondeoPrecioId { get; set; }
        public decimal? PrecioMaximo { get; set; }
        public decimal? FactorRedondeo { get; set; }
    }
}
