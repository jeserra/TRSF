using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LineasArticulosWeb
    {
        public int LineaArticuloWebId { get; set; }
        public string ClaveSis { get; set; }
        public string Politica { get; set; }
        public int LineaArticuloId { get; set; }
        public string Accion { get; set; }

        public virtual LineasArticulos LineaArticulo { get; set; }
    }
}
