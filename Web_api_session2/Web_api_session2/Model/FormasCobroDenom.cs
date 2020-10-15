using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FormasCobroDenom
    {
        public int FormaCobroDenomId { get; set; }
        public int FormaCobroId { get; set; }
        public decimal? Denominacion { get; set; }

        public virtual FormasCobro FormaCobro { get; set; }
    }
}
