using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ElementosCatClasif
    {
        public int ElementoId { get; set; }
        public int ValorClasifId { get; set; }

        public virtual ClasificadoresCatValores ValorClasif { get; set; }
    }
}
