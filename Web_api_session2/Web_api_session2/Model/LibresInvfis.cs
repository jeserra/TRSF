using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresInvfis
    {
        public int DoctoInvfisId { get; set; }

        public virtual DoctosInvfis DoctoInvfis { get; set; }
    }
}
