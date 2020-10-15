using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresCreditosCp
    {
        public int DoctoCpId { get; set; }

        public virtual DoctosCp DoctoCp { get; set; }
    }
}
