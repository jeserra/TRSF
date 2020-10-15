using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SubMovtosVe
    {
        public int DoctoVeDetId { get; set; }
        public int SubMovtoVeId { get; set; }

        public virtual DoctosVeDet DoctoVeDet { get; set; }
        public virtual DoctosVeDet SubMovtoVe { get; set; }
    }
}
