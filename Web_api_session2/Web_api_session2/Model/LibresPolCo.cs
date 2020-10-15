using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresPolCo
    {
        public int DoctoCoId { get; set; }

        public virtual DoctosCo DoctoCo { get; set; }
    }
}
