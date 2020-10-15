using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class VencimientosCargosVe
    {
        public int DoctoVeId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal? PctjeVen { get; set; }

        public virtual DoctosVe DoctoVe { get; set; }
    }
}
