using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImagenesCajas
    {
        public ImagenesCajas()
        {
            Cajas = new HashSet<Cajas>();
            ImagenesCajasDet = new HashSet<ImagenesCajasDet>();
        }

        public int ImagenesCajaId { get; set; }
        public string Nombre { get; set; }
        public string Activo { get; set; }
        public int TiempoEntreImagenes { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<Cajas> Cajas { get; set; }
        public virtual ICollection<ImagenesCajasDet> ImagenesCajasDet { get; set; }
    }
}
