using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class AtribArtsVariantes
    {
        public AtribArtsVariantes()
        {
            ValoresAtribArtsVariantes = new HashSet<ValoresAtribArtsVariantes>();
        }

        public int AtribId { get; set; }
        public int ArtPadreVarId { get; set; }
        public string Nombre { get; set; }
        public short Posicion { get; set; }

        public virtual ArticulosVariantes ArtPadreVar { get; set; }
        public virtual ICollection<ValoresAtribArtsVariantes> ValoresAtribArtsVariantes { get; set; }
    }
}
