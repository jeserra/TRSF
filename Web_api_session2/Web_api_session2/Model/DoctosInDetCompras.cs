using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosInDetCompras
    {
        public int ArticuloId { get; set; }
        public int DoctoInDetId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual DoctosInDet DoctoInDet { get; set; }
    }
}
