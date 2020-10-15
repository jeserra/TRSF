using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImagenesClientes
    {
        public int ImagenClienteId { get; set; }
        public int ClienteId { get; set; }
        public int RolImagenCliId { get; set; }
        public string Imagen { get; set; }

        public virtual Clientes Cliente { get; set; }
    }
}
