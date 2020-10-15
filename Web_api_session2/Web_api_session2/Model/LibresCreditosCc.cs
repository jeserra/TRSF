using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresCreditosCc
    {
        public int DoctoCcId { get; set; }

        public virtual DoctosCc DoctoCc { get; set; }
    }
}
