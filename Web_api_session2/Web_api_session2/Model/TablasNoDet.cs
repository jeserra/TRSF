using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TablasNoDet
    {
        public int TablaNoDetId { get; set; }
        public int TablaNoId { get; set; }
        public decimal? LimiteInferior { get; set; }
        public decimal? Cuota1 { get; set; }
        public decimal? Pctje1 { get; set; }
        public decimal? Cuota2 { get; set; }

        public virtual TablasNo TablaNo { get; set; }
    }
}
