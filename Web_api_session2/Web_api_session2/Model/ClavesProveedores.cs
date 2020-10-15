using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ClavesProveedores
    {
        public int ClaveProvId { get; set; }
        public string ClaveProv { get; set; }
        public int ProveedorId { get; set; }
        public int RolClaveProvId { get; set; }

        public virtual Proveedores Proveedor { get; set; }
    }
}
