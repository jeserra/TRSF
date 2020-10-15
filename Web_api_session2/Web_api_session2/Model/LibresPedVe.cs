using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresPedVe
    {
        public int DoctoVeId { get; set; }

        public virtual DoctosVe DoctoVe { get; set; }
    }
}
