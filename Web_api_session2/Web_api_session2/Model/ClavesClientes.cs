using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ClavesClientes
    {
        public int ClaveClienteId { get; set; }
        public string ClaveCliente { get; set; }
        public int ClienteId { get; set; }
        public int RolClaveCliId { get; set; }

        public virtual Clientes Cliente { get; set; }
    }
}
