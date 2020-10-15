using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CajasCajeros
    {
        public string TipoAcceso { get; set; }
        public int CajeroId { get; set; }
        public int CajaId { get; set; }

        public virtual Cajas Caja { get; set; }
        public virtual Cajeros Cajero { get; set; }
    }
}
