using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ValoresAtribArtsVariantes
    {
        public ValoresAtribArtsVariantes()
        {
            VariantesArtsDet = new HashSet<VariantesArtsDet>();
        }

        public int ValorAtribId { get; set; }
        public int AtribId { get; set; }
        public string Valor { get; set; }
        public short Posicion { get; set; }

        public virtual AtribArtsVariantes Atrib { get; set; }
        public virtual ICollection<VariantesArtsDet> VariantesArtsDet { get; set; }
    }
}
