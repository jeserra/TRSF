using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CompromArticulos
    {
        public int CompromArtId { get; set; }
        public int ArticuloId { get; set; }
        public int AlmacenId { get; set; }
        public decimal? UnidadesComprom { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual Articulos Articulo { get; set; }
    }
}
