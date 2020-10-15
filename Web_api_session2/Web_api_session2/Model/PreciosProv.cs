using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PreciosProv
    {
        public PreciosProv()
        {
            PoliticasPreciosProv = new HashSet<PoliticasPreciosProv>();
            PreciosCompraDet = new HashSet<PreciosCompraDet>();
        }

        public int PrecioProvId { get; set; }
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string IdInterno { get; set; }

        public virtual Proveedores Proveedor { get; set; }
        public virtual ICollection<PoliticasPreciosProv> PoliticasPreciosProv { get; set; }
        public virtual ICollection<PreciosCompraDet> PreciosCompraDet { get; set; }
    }
}
