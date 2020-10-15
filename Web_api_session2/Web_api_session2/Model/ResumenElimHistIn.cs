using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ResumenElimHistIn
    {
        public int AlmacenId { get; set; }
        public int ArticuloId { get; set; }
        public decimal? TotUnid { get; set; }
        public decimal? TotCosto { get; set; }
    }
}
