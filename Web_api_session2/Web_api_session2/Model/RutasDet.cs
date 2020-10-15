using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class RutasDet
    {
        public int RutaDetId { get; set; }
        public int RutaId { get; set; }
        public int Dia { get; set; }
        public int? DiaPosicion { get; set; }
        public int ClienteId { get; set; }
        public string ClaveCliente { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Rutas Ruta { get; set; }
    }
}
