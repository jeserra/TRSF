using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SnubeSucursales
    {
        public SnubeSucursales()
        {
            SnubeSucursalesDispersion = new HashSet<SnubeSucursalesDispersion>();
        }

        public int SnubeSucursalId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string ContactoNombre { get; set; }
        public string ContactoCorreo { get; set; }

        public virtual SnubeSucursalesConsultas SnubeSucursalesConsultas { get; set; }
        public virtual SnubeSucursalesLlaves SnubeSucursalesLlaves { get; set; }
        public virtual ICollection<SnubeSucursalesDispersion> SnubeSucursalesDispersion { get; set; }
    }
}
