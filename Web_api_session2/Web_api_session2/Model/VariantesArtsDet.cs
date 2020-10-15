using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class VariantesArtsDet
    {
        public int VarianteDetId { get; set; }
        public int VarianteId { get; set; }
        public int ValorAtribId { get; set; }

        public virtual ValoresAtribArtsVariantes ValorAtrib { get; set; }
        public virtual VariantesArts Variante { get; set; }
    }
}
