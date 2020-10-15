using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPvLigasDet
    {
        public int DoctoPvLigaId { get; set; }
        public int DoctoPvDetFteId { get; set; }
        public int DoctoPvDetDestId { get; set; }

        public virtual DoctosPvDet DoctoPvDetDest { get; set; }
        public virtual DoctosPvDet DoctoPvDetFte { get; set; }
        public virtual DoctosPvLigas DoctoPvLiga { get; set; }
    }
}
