using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class NivelesArticulos
    {
        public int NivelArtId { get; set; }
        public int ArticuloId { get; set; }
        public int AlmacenId { get; set; }
        public string Localizacion { get; set; }
        public decimal? InventarioMaximo { get; set; }
        public decimal? PuntoReorden { get; set; }
        public decimal? InventarioMinimo { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual Articulos Articulo { get; set; }
    }
}
