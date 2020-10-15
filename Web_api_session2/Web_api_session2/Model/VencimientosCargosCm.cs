using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class VencimientosCargosCm
    {
        public int DoctoCmId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal? PctjeVen { get; set; }

        public virtual DoctosCm DoctoCm { get; set; }
    }
}
