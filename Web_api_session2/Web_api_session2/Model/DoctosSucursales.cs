using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosSucursales
    {
        public string SistemaOrigen { get; set; }
        public int DoctoId { get; set; }
        public int SucursalId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Sucursales Sucursal { get; set; }
    }
}
