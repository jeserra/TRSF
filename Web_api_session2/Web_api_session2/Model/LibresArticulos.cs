using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresArticulos
    {
        public int ArticuloId { get; set; }

        public virtual Articulos Articulo { get; set; }
    }
}
