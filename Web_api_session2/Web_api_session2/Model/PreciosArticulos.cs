using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PreciosArticulos
    {
        public int PrecioArticuloId { get; set; }
        public int ArticuloId { get; set; }
        public int PrecioEmpresaId { get; set; }
        public decimal? Precio { get; set; }
        public int MonedaId { get; set; }
        public decimal? Margen { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual PreciosEmpresa PrecioEmpresa { get; set; }
    }
}
