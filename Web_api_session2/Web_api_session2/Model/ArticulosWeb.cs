using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ArticulosWeb
    {
        public int ArticuloWebId { get; set; }
        public string ClaveSis { get; set; }
        public string Politica { get; set; }
        public int ArticuloId { get; set; }
        public string Accion { get; set; }

        public virtual Articulos Articulo { get; set; }
    }
}
