using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CertCfdProv
    {
        public int ProveedorId { get; set; }
        public string NumSerie { get; set; }
        public string Certificado { get; set; }

        public virtual Proveedores Proveedor { get; set; }
    }
}
