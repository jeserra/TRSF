using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ExisDiscretos
    {
        public int ExisDiscretoId { get; set; }
        public int ArtDiscretoId { get; set; }
        public int AlmacenId { get; set; }
        public decimal? Existencia { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual ArticulosDiscretos ArtDiscreto { get; set; }
    }
}
