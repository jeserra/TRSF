using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SalariosMin
    {
        public int SalarioMinId { get; set; }
        public string Zona { get; set; }
        public DateTime FechaVigencia { get; set; }
        public decimal? SalarioDiario { get; set; }
    }
}
