using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DesgloseEnDiscretosCm
    {
        public int DesgloseDiscretoCmId { get; set; }
        public int DoctoCmDetId { get; set; }
        public int ArtDiscretoId { get; set; }
        public decimal? Unidades { get; set; }

        public virtual ArticulosDiscretos ArtDiscreto { get; set; }
        public virtual DoctosCmDet DoctoCmDet { get; set; }
    }
}
