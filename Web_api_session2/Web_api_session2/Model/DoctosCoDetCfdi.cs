using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCoDetCfdi
    {
        public int DoctoCoDetId { get; set; }
        public int DoctoCoCfdiId { get; set; }

        public virtual DoctosCoCfdi DoctoCoCfdi { get; set; }
        public virtual DoctosCoDet DoctoCoDet { get; set; }
    }
}
