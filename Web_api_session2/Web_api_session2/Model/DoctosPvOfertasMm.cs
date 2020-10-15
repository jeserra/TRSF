using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPvOfertasMm
    {
        public DoctosPvOfertasMm()
        {
            DoctosPvOfertasMmDet = new HashSet<DoctosPvOfertasMmDet>();
        }

        public int DoctoPvOfertaMmId { get; set; }
        public int DoctoPvId { get; set; }
        public int NombreOfertaId { get; set; }

        public virtual DoctosPv DoctoPv { get; set; }
        public virtual DoctosPvNombresOfertasMm NombreOferta { get; set; }
        public virtual ICollection<DoctosPvOfertasMmDet> DoctosPvOfertasMmDet { get; set; }
    }
}
