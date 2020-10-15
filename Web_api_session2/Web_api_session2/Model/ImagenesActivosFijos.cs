using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImagenesActivosFijos
    {
        public int ImagenActfijoId { get; set; }
        public int ActivoFijoId { get; set; }
        public int RolImagenActfijoId { get; set; }
        public string Imagen { get; set; }

        public virtual ActivosFijos ActivoFijo { get; set; }
    }
}
