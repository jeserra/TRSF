using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresActFijos
    {
        public int ActivoFijoId { get; set; }

        public virtual ActivosFijos ActivoFijo { get; set; }
    }
}
