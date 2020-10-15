using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCmLigasDet
    {
        public int DoctoCmLigaId { get; set; }
        public int DoctoCmDetFteId { get; set; }
        public int DoctoCmDetDestId { get; set; }

        public virtual DoctosCmDet DoctoCmDetDest { get; set; }
        public virtual DoctosCmDet DoctoCmDetFte { get; set; }
        public virtual DoctosCmLigas DoctoCmLiga { get; set; }
    }
}
