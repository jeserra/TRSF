using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImagenesArticulos
    {
        public int ImagenArticuloId { get; set; }
        public int ArticuloId { get; set; }
        public int RolImagenArtId { get; set; }
        public string Imagen { get; set; }

        public virtual Articulos Articulo { get; set; }
    }
}
