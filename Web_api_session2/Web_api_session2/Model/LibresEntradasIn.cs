using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresEntradasIn
    {
        public int DoctoInId { get; set; }

        public virtual DoctosIn DoctoIn { get; set; }
    }
}
