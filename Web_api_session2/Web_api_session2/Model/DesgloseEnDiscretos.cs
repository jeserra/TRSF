using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DesgloseEnDiscretos
    {
        public int DesgloseDiscretoId { get; set; }
        public int DoctoInDetId { get; set; }
        public int ArtDiscretoId { get; set; }
        public decimal? Unidades { get; set; }

        public virtual ArticulosDiscretos ArtDiscreto { get; set; }
        public virtual DoctosInDet DoctoInDet { get; set; }
    }
}
