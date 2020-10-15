using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SubMovtosCc
    {
        public int DoctoCcId { get; set; }
        public int SubMovtoId { get; set; }

        public virtual DoctosCc DoctoCc { get; set; }
        public virtual DoctosCc SubMovto { get; set; }
    }
}
