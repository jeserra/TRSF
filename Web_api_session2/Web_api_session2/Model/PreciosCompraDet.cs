using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PreciosCompraDet
    {
        public int PrecioCompraDetId { get; set; }
        public int PrecioCompraId { get; set; }
        public int PrecioProvId { get; set; }
        public decimal? PrecioUven { get; set; }
        public decimal? PrecioUcom { get; set; }
        public int MonedaId { get; set; }

        public virtual Monedas Moneda { get; set; }
        public virtual PreciosCompra PrecioCompra { get; set; }
        public virtual PreciosProv PrecioProv { get; set; }
    }
}
