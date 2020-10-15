using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class MovtosCajasCajeros
    {
        public int MovtoCajaCjoId { get; set; }
        public int MovtoCajaId { get; set; }
        public int CajeroId { get; set; }

        public virtual Cajeros Cajero { get; set; }
        public virtual MovtosCajas MovtoCaja { get; set; }
    }
}
