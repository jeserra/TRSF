using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPvTranPendTc
    {
        public int DoctoPvTranPendTcId { get; set; }
        public int DoctoPvCobroId { get; set; }
        public int FormaCobroId { get; set; }
        public int CajaId { get; set; }
        public string ParamsCance { get; set; }
        public string DeclinadoEmv { get; set; }

        public virtual Cajas Caja { get; set; }
        public virtual FormasCobro FormaCobro { get; set; }
    }
}
