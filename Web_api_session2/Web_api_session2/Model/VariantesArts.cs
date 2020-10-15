using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class VariantesArts
    {
        public VariantesArts()
        {
            VariantesArtsDet = new HashSet<VariantesArtsDet>();
        }

        public int VarianteId { get; set; }
        public int ArtPadreVarId { get; set; }
        public int? ArtHijoVarId { get; set; }
        public string Descripcion { get; set; }

        public virtual Articulos ArtHijoVar { get; set; }
        public virtual ArticulosVariantes ArtPadreVar { get; set; }
        public virtual ICollection<VariantesArtsDet> VariantesArtsDet { get; set; }
    }
}
