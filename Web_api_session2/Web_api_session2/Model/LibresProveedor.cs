using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresProveedor
    {
        public int ProveedorId { get; set; }

        public virtual Proveedores Proveedor { get; set; }
    }
}
