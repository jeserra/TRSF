using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class JuegosAEnsamblar
    {
        public int ReporteId { get; set; }
        public int JuegoId { get; set; }
        public decimal? Unidades { get; set; }

        public virtual Articulos Juego { get; set; }
    }
}
