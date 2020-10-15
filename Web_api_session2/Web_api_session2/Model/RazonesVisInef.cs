using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class RazonesVisInef
    {
        public RazonesVisInef()
        {
            Visitas = new HashSet<Visitas>();
        }

        public int RazonVisInefId { get; set; }
        public string Nombre { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public int? VersionRegistro { get; set; }

        public virtual ICollection<Visitas> Visitas { get; set; }
    }
}
