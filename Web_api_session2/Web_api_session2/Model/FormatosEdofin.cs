using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FormatosEdofin
    {
        public FormatosEdofin()
        {
            EspecsEdofin = new HashSet<EspecsEdofin>();
            FormatosEdofinDet = new HashSet<FormatosEdofinDet>();
        }

        public int FormatoEdofinId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<EspecsEdofin> EspecsEdofin { get; set; }
        public virtual ICollection<FormatosEdofinDet> FormatosEdofinDet { get; set; }
    }
}
