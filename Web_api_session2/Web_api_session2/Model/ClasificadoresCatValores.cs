using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ClasificadoresCatValores
    {
        public ClasificadoresCatValores()
        {
            ElementosCatClasif = new HashSet<ElementosCatClasif>();
            OfertasMmDet = new HashSet<OfertasMmDet>();
        }

        public int ValorClasifId { get; set; }
        public int ClasificadorId { get; set; }
        public string Valor { get; set; }
        public short Posicion { get; set; }

        public virtual ClasificadoresCat Clasificador { get; set; }
        public virtual ICollection<ElementosCatClasif> ElementosCatClasif { get; set; }
        public virtual ICollection<OfertasMmDet> OfertasMmDet { get; set; }
    }
}
