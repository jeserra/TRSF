using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DesgloseEnDiscretosVe
    {
        public int DesgloseDiscretoVeId { get; set; }
        public int DoctoVeDetId { get; set; }
        public int ArtDiscretoId { get; set; }
        public decimal? Unidades { get; set; }

        public virtual ArticulosDiscretos ArtDiscreto { get; set; }
        public virtual DoctosVeDet DoctoVeDet { get; set; }
    }
}
