using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImpuestosArticulos
    {
        public int ImpuestoArtId { get; set; }
        public int ArticuloId { get; set; }
        public int ImpuestoId { get; set; }
        public decimal? UnidadesImpuesto { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual Impuestos Impuesto { get; set; }
    }
}
