using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PlazosCondPagCp
    {
        public int PlazoCondPagId { get; set; }
        public int CondPagoId { get; set; }
        public short DiasPlazo { get; set; }
        public decimal? PctjeVen { get; set; }

        public virtual CondicionesPagoCp CondPago { get; set; }
    }
}
