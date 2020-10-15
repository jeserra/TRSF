using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SnubeSucursalesConsultas
    {
        public int SnubeSucursalId { get; set; }
        public short Posicion { get; set; }
        public string ConsultarExistencia { get; set; }

        public virtual SnubeSucursales SnubeSucursal { get; set; }
    }
}
