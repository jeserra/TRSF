using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresCargosPerCc
    {
        public int CargoPeriodId { get; set; }

        public virtual CargosPeriodicosCc CargoPeriod { get; set; }
    }
}
