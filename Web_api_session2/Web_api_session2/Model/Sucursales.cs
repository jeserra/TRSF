using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Sucursales
    {
        public Sucursales()
        {
            DoctosSucursales = new HashSet<DoctosSucursales>();
        }

        public int SucursalId { get; set; }
        public string ClaveSistema { get; set; }
        public string NombreCorto { get; set; }
        public string Activa { get; set; }

        public virtual ICollection<DoctosSucursales> DoctosSucursales { get; set; }
    }
}
