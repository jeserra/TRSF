using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImagenesProveedores
    {
        public int ImagenProvId { get; set; }
        public int ProveedorId { get; set; }
        public int RolImagenProvId { get; set; }
        public string Imagen { get; set; }

        public virtual Proveedores Proveedor { get; set; }
    }
}
