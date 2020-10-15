using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresClientes
    {
        public int ClienteId { get; set; }

        public virtual Clientes Cliente { get; set; }
    }
}
