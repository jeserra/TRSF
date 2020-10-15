using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SnubeSucursalesLlaves
    {
        public int SnubeSucursalId { get; set; }
        public string ApiToken { get; set; }

        public virtual SnubeSucursales SnubeSucursal { get; set; }
    }
}
