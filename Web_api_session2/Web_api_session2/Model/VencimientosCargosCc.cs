using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class VencimientosCargosCc
    {
        public int DoctoCcId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal? PctjeVen { get; set; }

        public virtual DoctosCc DoctoCc { get; set; }
    }
}
