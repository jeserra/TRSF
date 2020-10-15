using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ClavesArticulos
    {
        public ClavesArticulos()
        {
            JuegosDet = new HashSet<JuegosDet>();
        }

        public int ClaveArticuloId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public int RolClaveArtId { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual ICollection<JuegosDet> JuegosDet { get; set; }
    }
}
