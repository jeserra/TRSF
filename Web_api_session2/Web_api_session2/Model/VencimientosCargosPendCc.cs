using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class VencimientosCargosPendCc
    {
        public int DoctoPendCcId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal PctjeVen { get; set; }

        public virtual DoctosPendCc DoctoPendCc { get; set; }
    }
}
