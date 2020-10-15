using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class VencimientosCargosCp
    {
        public int DoctoCpId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal? PctjeVen { get; set; }

        public virtual DoctosCp DoctoCp { get; set; }
    }
}
