using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ArticulosVariantes
    {
        public ArticulosVariantes()
        {
            AtribArtsVariantes = new HashSet<AtribArtsVariantes>();
            VariantesArts = new HashSet<VariantesArts>();
        }

        public int ArtPadreVarId { get; set; }

        public virtual Articulos ArtPadreVar { get; set; }
        public virtual ICollection<AtribArtsVariantes> AtribArtsVariantes { get; set; }
        public virtual ICollection<VariantesArts> VariantesArts { get; set; }
    }
}
