using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SubMovtosIn
    {
        public int DoctoInDetId { get; set; }
        public int SubMovtoId { get; set; }

        public virtual DoctosInDet DoctoInDet { get; set; }
        public virtual DoctosInDet SubMovto { get; set; }
    }
}
