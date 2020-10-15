using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ArticulosTiendaLinea
    {
        public int ArticulosTiendaLineaId { get; set; }
        public string ClaveSis { get; set; }
        public int ArticuloId { get; set; }
        public string ArticuloTwId { get; set; }

        public virtual Articulos Articulo { get; set; }
    }
}
