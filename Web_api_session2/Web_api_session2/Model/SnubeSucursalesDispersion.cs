using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SnubeSucursalesDispersion
    {
        public int SnubeSucursalDispId { get; set; }
        public int SnubeSucursalId { get; set; }
        public string Tipo { get; set; }
        public int ElementoId { get; set; }

        public virtual SnubeSucursales SnubeSucursal { get; set; }
    }
}
