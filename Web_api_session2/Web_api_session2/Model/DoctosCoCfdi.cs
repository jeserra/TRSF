using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCoCfdi
    {
        public DoctosCoCfdi()
        {
            DoctosCoDetCfdi = new HashSet<DoctosCoDetCfdi>();
        }

        public int DoctoCoCfdiId { get; set; }
        public int DoctoCoId { get; set; }
        public int CfdiId { get; set; }
        public string EsGlobal { get; set; }

        public virtual RepositorioCfdi Cfdi { get; set; }
        public virtual DoctosCo DoctoCo { get; set; }
        public virtual ICollection<DoctosCoDetCfdi> DoctosCoDetCfdi { get; set; }
    }
}
