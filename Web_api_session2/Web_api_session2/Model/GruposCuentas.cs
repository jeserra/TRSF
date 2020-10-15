using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class GruposCuentas
    {
        public GruposCuentas()
        {
            FormatosEdofinDet = new HashSet<FormatosEdofinDet>();
            GruposCuentasDet = new HashSet<GruposCuentasDet>();
        }

        public int GrupoCuentasId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Subtipo { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<FormatosEdofinDet> FormatosEdofinDet { get; set; }
        public virtual ICollection<GruposCuentasDet> GruposCuentasDet { get; set; }
    }
}
