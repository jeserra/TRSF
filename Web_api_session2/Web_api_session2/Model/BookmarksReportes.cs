using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class BookmarksReportes
    {
        public int ReporteId { get; set; }
        public int ObjetoId { get; set; }
        public DateTime? Fecha { get; set; }
        public int? OrdenSeleccion { get; set; }
    }
}
