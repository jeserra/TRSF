using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class JuegosDet
    {
        public int ArticuloId { get; set; }
        public int? ClaveArticuloId { get; set; }
        public int ComponenteId { get; set; }
        public decimal? Unidades { get; set; }
        public string EsReemplazable { get; set; }
        public string PermitirModifUnid { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual ClavesArticulos ClaveArticulo { get; set; }
        public virtual Articulos Componente { get; set; }
    }
}
