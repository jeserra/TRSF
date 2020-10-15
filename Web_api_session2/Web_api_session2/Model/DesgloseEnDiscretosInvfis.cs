using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DesgloseEnDiscretosInvfis
    {
        public int DesglDiscretoInvfisId { get; set; }
        public int DoctoInvfisDetId { get; set; }
        public int ArtDiscretoId { get; set; }
        public decimal? Unidades { get; set; }

        public virtual ArticulosDiscretos ArtDiscreto { get; set; }
        public virtual DoctosInvfisDet DoctoInvfisDet { get; set; }
    }
}
