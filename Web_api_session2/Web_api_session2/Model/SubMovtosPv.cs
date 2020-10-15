using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SubMovtosPv
    {
        public int DoctoPvDetId { get; set; }
        public int SubMovtoPvId { get; set; }

        public virtual DoctosPvDet DoctoPvDet { get; set; }
        public virtual DoctosPvDet SubMovtoPv { get; set; }
    }
}
