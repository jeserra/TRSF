using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SubMovtosCp
    {
        public int DoctoCpId { get; set; }
        public int SubMovtoId { get; set; }

        public virtual DoctosCp DoctoCp { get; set; }
        public virtual DoctosCp SubMovto { get; set; }
    }
}
