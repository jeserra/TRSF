using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImagenesCajasDet
    {
        public int ImagenesCajaDetId { get; set; }
        public int ImagenesCajaId { get; set; }
        public string Nombre { get; set; }
        public string Activa { get; set; }
        public int Posicion { get; set; }
        public string Imagen { get; set; }

        public virtual ImagenesCajas ImagenesCaja { get; set; }
    }
}
