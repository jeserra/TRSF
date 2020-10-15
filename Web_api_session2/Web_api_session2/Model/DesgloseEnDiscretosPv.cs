using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DesgloseEnDiscretosPv
    {
        public int DesgloseDiscretoPvId { get; set; }
        public int DoctoPvDetId { get; set; }
        public int ArtDiscretoId { get; set; }
        public decimal? Unidades { get; set; }

        public virtual ArticulosDiscretos ArtDiscreto { get; set; }
        public virtual DoctosPvDet DoctoPvDet { get; set; }
    }
}
