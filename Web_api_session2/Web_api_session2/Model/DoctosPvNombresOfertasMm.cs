using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPvNombresOfertasMm
    {
        public DoctosPvNombresOfertasMm()
        {
            DoctosPvOfertasMm = new HashSet<DoctosPvOfertasMm>();
        }

        public int NombreOfertaId { get; set; }
        public string NombreOferta { get; set; }

        public virtual ICollection<DoctosPvOfertasMm> DoctosPvOfertasMm { get; set; }
    }
}
